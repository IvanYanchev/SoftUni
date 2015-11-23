using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    public class Swine : Animal
    {
        public Swine(string id)
            : base(id, 20)
        {
        }

        public override void Eat(IEdible food, int quantity)
        {
            this.Health += food.HealthEffect * 2 * quantity;
        }

        public override Product GetProduct()
        {
            if (this.IsAlive)
            {
                this.Health = 0;
                return new Food(this.Id + "Product", ProductType.PorkMeat, FoodType.Meat, 1, 5);
            }

            return null;
        }

        public override void Starve()
        {
            this.Health -= 3;
        }
    }
}
