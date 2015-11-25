using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    public abstract class Spell : ISpell
    {
        private int damage;
        private int energyCost;

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public int EnergyCost
        {
            get { return this.energyCost; }
            set { this.energyCost = value; }
        }

        protected Spell(int attack)
        {
            this.Damage = attack;
        }
    }
}
