using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable
    {
        private int health;
        private int productionQuantity;
        private bool isAlive = true;

        public FarmUnit(string id, int health)
            : base(id)
        {
            this.Health = health;
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    this.isAlive = false;
                }

                this.health = value;
            }
        }

        public bool IsAlive
        {
            get { return this.isAlive; }
        }

        public int ProductionQuantity
        {
            get { return this.productionQuantity; }
            set { this.productionQuantity = value; }
        }

        public abstract Product GetProduct();
    }
}
