using System;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is required");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be positive");
                }

                this.price = value;
            }
        }

        public int Calories
        {
            get { return this.calories; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The calories must be positive");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The quantity per serving must be positive");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; set; }

        public int TimeToPrepare
        {
            get { return this.timeToPrepare; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The time to prepare must be positive");
                }

                this.timeToPrepare = value;
            }
        }

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("==  {0} == ${1:F2}\n", this.Name, this.Price);
            sb.AppendFormat("Per serving: {0} {1}, {2} kcal\n", this.QuantityPerServing, this.Unit == MetricUnit.Grams ? "g" : "ml", this.Calories);
            sb.AppendFormat("Ready in {0} minutes", this.TimeToPrepare);

            return sb.ToString();
        }
    }
}
