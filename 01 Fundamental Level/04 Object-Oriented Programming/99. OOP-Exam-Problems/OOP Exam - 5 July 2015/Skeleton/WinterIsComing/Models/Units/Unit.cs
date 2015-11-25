using System.Text;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Units
{
    public abstract class Unit : IUnit
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; }
        public int Range { get; }
        public int AttackPoints { get; set; }
        public int HealthPoints { get; set; }
        public int DefensePoints { get; set; }
        public int EnergyPoints { get; set; }
        public ICombatHandler CombatHandler { get; set; }

        protected Unit(string name, int x, int y, int attackPoints, int healthPoints, int defensePoints, int energyPoints, int range)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.DefensePoints = defensePoints;
            this.EnergyPoints = energyPoints;
            this.Range = range;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(">{0} - {1} at ({2},{3})", this.Name, this.GetType().Name, this.X, this.Y).AppendLine();

            if (this.HealthPoints<=0)
            {
                sb.Append("(Dead)");
            }
            else
            {
                sb.AppendFormat("-Health points = {0}", this.HealthPoints).AppendLine();
                sb.AppendFormat("-Attack points = {0}", this.AttackPoints).AppendLine();
                sb.AppendFormat("-Defense points = {0}", this.DefensePoints).AppendLine();
                sb.AppendFormat("-Energy points = {0}", this.EnergyPoints).AppendLine();
                sb.AppendFormat("-Range = {0}", this.Range);
            }

            return sb.ToString();
        }
    }
}
