using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Restaurant : IRestaurant
    {
        public string Name { get; }
        public string Location { get; }
        public IList<IRecipe> Recipes { get; }

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public void AddRecipe(IRecipe recipe)
        {
            if (!this.Recipes.Contains(recipe))
            {
                this.Recipes.Add(recipe);
            }
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("***** {0} - {1} *****", this.Name, this.Location);

            if (this.Recipes.Count == 0)
            {
                sb.Append("\nNo recipes... yet");
            }
            else
            {
                var menu = new Dictionary<String, IOrderedEnumerable<IRecipe>>();

                var drinks = this.Recipes
                    .Where(r => r is IDrink)
                    .OrderBy(d => d.Name);
                if (drinks.Count() > 0)
                {
                    menu.Add("~~~~~ DRINKS ~~~~~", drinks);
                }


                var salads = this.Recipes
                    .Where(r => r is ISalad)
                    .OrderBy(s => s.Name);
                if (salads.Count() > 0)
                {
                    menu.Add("~~~~~ SALADS ~~~~~", salads);
                }


                var mainCourses = this.Recipes
                    .Where(r => r is IMainCourse)
                    .OrderBy(mc => mc.Name);
                if (mainCourses.Count() > 0)
                {
                    menu.Add("~~~~~ MAIN COURSES ~~~~~", mainCourses);
                }


                var deserts = this.Recipes
                    .Where(r => r is IDessert)
                    .OrderBy(d => d.Name);
                if (deserts.Count() > 0)
                {
                    menu.Add("~~~~~ DESSERTS ~~~~~", deserts);
                }

                foreach (KeyValuePair<string, IOrderedEnumerable<IRecipe>> pair in menu)
                {
                    sb.AppendFormat("\n{0}", pair.Key);
                    foreach (IRecipe recipe in pair.Value)
                    {
                        sb.AppendFormat("\n{0}", recipe);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
