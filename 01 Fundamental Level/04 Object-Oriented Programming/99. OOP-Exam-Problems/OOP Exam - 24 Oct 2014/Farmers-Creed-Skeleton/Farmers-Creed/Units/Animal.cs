namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit
    {
        protected Animal(string id, int health)
            : base(id, health)
        {
        }

        public abstract void Eat(IEdible food, int quantity);

        public virtual void Starve()
        {
            this.Health--;
        }

        public override string ToString()
        {
            //--(ClassType) (Id), Health: (Health) / DEAD

            return string.Format(
                "--{0} {1}, {2}",
                this.GetType().Name,
                this.Id,
                this.IsAlive ? string.Format("Health: {0}", this.Health) : "DEAD");
        }
    }
}
