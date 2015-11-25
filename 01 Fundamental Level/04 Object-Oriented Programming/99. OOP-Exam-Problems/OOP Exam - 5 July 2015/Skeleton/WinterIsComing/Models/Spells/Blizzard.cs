using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    public class Blizzard : Spell
    {
        private const int BlizzardEnergyCost = 40;

        public Blizzard(int attack) : base(attack)
        {
            this.EnergyCost = Blizzard.BlizzardEnergyCost;
        }
    }
}
