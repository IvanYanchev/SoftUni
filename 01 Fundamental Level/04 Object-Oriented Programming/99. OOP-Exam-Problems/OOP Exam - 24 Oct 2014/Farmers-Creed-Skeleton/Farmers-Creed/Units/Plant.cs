namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit
    {
        private int growTime;
        private bool hasGrown = false;

        protected Plant(string id, int health, int growTime)
            : base(id, health)
        {
            this.GrowTime = growTime;
        }

        public bool HasGrown
        {
            get { return this.hasGrown; }
        }

        public int GrowTime
        {
            get { return this.growTime; }
            set
            {
                if (value == 0)
                {
                    this.hasGrown = true;
                }

                this.growTime = value;
            }
        }

        public virtual void Water()
        {
            this.Health += 2;
        }

        public virtual void Wither()
        {
            this.Health--;
        }

        public virtual void Grow()
        {
            if (this.GrowTime > 0)
            {
                this.GrowTime--;
            }
        }

        public override string ToString()
        {
            //--(ClassType) (Id), Health: (Health), Grown: (Yes/No) / DEAD

            return string.Format(
                "--{0} {1}, {2}",
                this.GetType().Name,
                this.Id,
                this.IsAlive ? string.Format("Health: {0}, Grown: {1}", this.Health, this.HasGrown ? "Yes" : "No") : "DEAD");
        }
    }
}
