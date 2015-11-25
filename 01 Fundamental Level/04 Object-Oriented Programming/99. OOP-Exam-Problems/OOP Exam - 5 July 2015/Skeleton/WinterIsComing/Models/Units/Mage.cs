using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class Mage : Unit
    {
        private const int MageAttack = 80;
        private const int MageHealth = 80;
        private const int MageDefense = 40;
        private const int MageEnergy = 120;
        private const int MageRange = 2;

        private bool isAlternateSpell;

        public bool IsAlternateSpell
        {
            get { return this.isAlternateSpell; }
            set { this.isAlternateSpell = value; }
        }

        public Mage(string name, int x, int y) 
            : base(name, x, y, MageAttack, MageHealth, MageDefense, MageEnergy, MageRange)
        {
            this.CombatHandler = new MageCombatHandler(this);
            this.IsAlternateSpell = false;
        }
    }
}
