using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Dessert : Meal, IDessert
    {
        private bool withSugar;

        public Dessert(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }

        public bool WithSugar
        {
            get { return this.withSugar; }
            set { this.withSugar = value; }
        }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", !this.WithSugar ? "[NO SUGAR] " : "", this.IsVegan ? "[VEGAN] " : "") + base.ToString();
        }
    }
}
