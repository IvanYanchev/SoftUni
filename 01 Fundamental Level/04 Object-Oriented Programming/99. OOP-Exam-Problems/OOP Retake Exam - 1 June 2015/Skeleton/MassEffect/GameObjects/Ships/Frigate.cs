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
    public class Frigate : Starship
    {
        public Frigate(string name, StarSystem location)
            : base(name, 60, 50, 30, 220, location)
        {
        }

        public int ProjectilesFired { get; set; }

        public override IProjectile ProduceAttack()
        {
            this.ProjectilesFired++;
            return new ShieldReaver(this.Damage);
        }
    }
}
