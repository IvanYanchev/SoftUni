using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class IceGiant : Unit
    {
        private const int IceGiantAttack = 150;
        private const int IceGiantHealth = 300;
        private const int IceGiantDefense = 60;
        private const int IceGiantEnergy = 50;
        private const int IceGiantRange = 1;

        public IceGiant(string name, int x, int y) 
            : base(name, x, y, IceGiantAttack, IceGiantHealth, IceGiantDefense, IceGiantEnergy, IceGiantRange)
        {
            this.CombatHandler = new IceGiantCombatHandler(this);
        }
    }
}
