using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    public class Cow : Animal
    {
        private const int CowHealth = 15;

        public Cow(string id)
            : base(id, Cow.CowHealth)
        {
        }

        public override Product GetProduct()
        {
            if (this.IsAlive)
            {
                this.Health -= 2;
                return new Food(this.Id + "Product", ProductType.Milk, FoodType.Organic, 6, 4);
            }

            return null;
        }

        public override void Eat(IEdible food, int quantity)
        {
            if (food.FoodType == FoodType.Organic)
            {
                this.Health += food.HealthEffect * quantity;
            }
            else if (food.FoodType == FoodType.Meat)
            {
                this.Health -= food.HealthEffect * quantity;
            }
        }
    }
}
