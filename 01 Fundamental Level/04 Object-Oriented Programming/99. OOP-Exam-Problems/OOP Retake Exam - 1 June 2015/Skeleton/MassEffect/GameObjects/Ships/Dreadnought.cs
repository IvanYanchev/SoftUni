using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought : Starship
    {
        public Dreadnought(string name, StarSystem location) 
            : base(name, 200, 300, 150, 700, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new Laser(this.Shields / 2 + this.Damage);
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            base.RespondToAttack(attack);
            this.Shields -= 50;
            if (this.Shields < 0)
            {
                this.Shields = 0;
            }
        }
    }
}
