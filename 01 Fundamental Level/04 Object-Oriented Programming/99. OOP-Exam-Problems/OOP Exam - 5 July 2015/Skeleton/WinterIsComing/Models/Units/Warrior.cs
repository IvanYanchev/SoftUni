using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class Warrior : Unit
    {
        private const int WarriorAttack = 120;
        private const int WarriorHealth = 180;
        private const int WarriorDefense = 70;
        private const int WarriorEnergy = 60;
        private const int WarriorRange = 1;

        public Warrior(string name, int x, int y) 
            : base(name, x, y, WarriorAttack, WarriorHealth, WarriorDefense, WarriorEnergy, WarriorRange)
        {
            this.CombatHandler = new WarriorCombatHandler(this);
        }
    }
}
