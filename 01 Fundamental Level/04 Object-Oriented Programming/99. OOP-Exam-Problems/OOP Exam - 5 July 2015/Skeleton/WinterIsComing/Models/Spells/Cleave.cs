using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    public class Cleave : Spell
    {
        private const int CleaveEnergyCost = 15;

        public Cleave(int attack) : base(attack)
        {
            this.EnergyCost = Cleave.CleaveEnergyCost;
        }
    }
}
