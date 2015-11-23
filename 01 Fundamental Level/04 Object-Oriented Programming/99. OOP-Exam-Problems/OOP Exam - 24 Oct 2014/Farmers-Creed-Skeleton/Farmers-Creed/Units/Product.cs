namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;

    public class Product : GameObject, IProduct
    {
        private int quantity;
        private ProductType productType;

        public Product(string id, ProductType productType, int quantity)
            : base(id)
        {
            this.Quantity = quantity;
            this.ProductType = productType;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product quantity cannot be negative!");
                }
                this.quantity = value;
            }
        }

        public ProductType ProductType
        {
            get { return this.productType; }
            set { this.productType = value; }
        }

        public override string ToString()
        {
            //--(ClassType) (Id), Quantity: (Quantity), Product Type: (ProductType), Food Type: (FoodType), Health Effect: (HealthEffect)

            return string.Format(
                "--{0} {1}, Quantity: {2}, Product Type: {3}{4}",
                this.GetType().Name,
                this.Id,
                this.Quantity,
                this.ProductType,
                this is Food ? string.Format(", Food Type: {0}, Health Effect: {1}", ((Food) this).FoodType, ((Food)this).HealthEffect) : "");
        }
    }
}
