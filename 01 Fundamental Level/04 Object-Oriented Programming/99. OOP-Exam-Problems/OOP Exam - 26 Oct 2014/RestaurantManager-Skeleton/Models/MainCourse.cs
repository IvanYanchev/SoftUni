using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool isVegan, string type) 
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare, isVegan)
        {
            MainCourseType mcType;
            if (Enum.TryParse(type, out mcType))
            {
                this.Type = mcType;
            }
        }

        public MainCourseType Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", this.IsVegan ? "[VEGAN] " : "") + base.ToString() + string.Format("\nType: {0}", this.Type);
        }
    }
}
