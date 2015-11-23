using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Salad : Meal, ISalad
    {
        private const bool SaladIsVegan = true;

        public Salad(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare, Salad.SaladIsVegan)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; }

        public override string ToString()
        {
            return string.Format("{0}", this.IsVegan ? "[VEGAN] " : "") + base.ToString() + string.Format("\nContains pasta: {0}", this.ContainsPasta ? "yes" : "no");
        }
    }
}
