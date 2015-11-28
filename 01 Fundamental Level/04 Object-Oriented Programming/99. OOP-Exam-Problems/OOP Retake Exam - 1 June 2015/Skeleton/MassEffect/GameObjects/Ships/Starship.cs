using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public abstract class Starship : IStarship
    {
        private List<Enhancement> enhancements;

        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location, params Enhancement[] enhancements)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;

            this.AddEnhancements(enhancements);
        }

        public IEnumerable<Enhancement> Enhancements
        {
            get { return this.enhancements; }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            this.enhancements.Add(enhancement);

            this.Damage += enhancement.DamageBonus;
            this.Shields += enhancement.ShieldBonus;
            this.Fuel += enhancement.FuelBonus;
        }

        public string Name { get; set; }

        public int Health { get; set; }
        public int Shields { get; set; }
        public int Damage { get; set; }
        public double Fuel { get; set; }
        public StarSystem Location { get; set; }

        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile attack)
        {
            switch (attack.GetType().Name)
            {
                case "Laser":
                    if (attack.Damage <= this.Shields)
                    {
                        this.Shields -= attack.Damage;
                    }
                    else
                    {
                        this.Health -= (attack.Damage - this.Shields);
                        this.Shields = 0;
                    }
                    break;
                case "PenetrationShell":
                    this.Health -= attack.Damage;
                    break;
                case "ShieldReaver":
                    this.Health -= attack.Damage;
                    this.Shields -= 2*attack.Damage;
                    if (this.Shields < 0)
                    {
                        this.Shields = 0;
                    }
                    break;
            }
        }

        private void AddEnhancements(ICollection<Enhancement> enhancements)
        {
            this.enhancements = new List<Enhancement>();

            foreach (Enhancement enhancement in enhancements)
            {
                this.AddEnhancement(enhancement);
            }
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            report.AppendFormat(
                "--{0} - {1}",
                this.Name,
                this.GetType().Name)
                .AppendLine();

            if (this.Health <= 0)
            {
                report.Append("(Destroyed)");
            }
            else
            {
                report.AppendFormat("-Location: {0}", this.Location.Name).AppendLine();
                report.AppendFormat("-Health: {0}", this.Health).AppendLine();
                report.AppendFormat("-Shields: {0}", this.Shields).AppendLine();
                report.AppendFormat("-Damage: {0}", this.Damage).AppendLine();
                report.AppendFormat("-Fuel: {0:F1}", this.Fuel).AppendLine();
                report.AppendFormat("-Enhancements: {0}", this.Enhancements.Any() ? string.Join(", ", this.Enhancements) : "N/A");

                if (this is Frigate)
                {
                    report.AppendLine().AppendFormat("-Projectiles fired: {0}", (this as Frigate).ProjectilesFired);
                }
            }

            return report.ToString();
        }
    }
}
