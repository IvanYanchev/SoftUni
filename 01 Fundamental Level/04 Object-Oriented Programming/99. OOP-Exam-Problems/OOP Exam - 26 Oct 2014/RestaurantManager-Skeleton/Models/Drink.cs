using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Drink : Recipe, IDrink
    {
        public Drink(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
        }

        public bool IsCarbonated { get; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nCarbonated: {0}", this.IsCarbonated ? "yes" : "no");
        }
    }
}
