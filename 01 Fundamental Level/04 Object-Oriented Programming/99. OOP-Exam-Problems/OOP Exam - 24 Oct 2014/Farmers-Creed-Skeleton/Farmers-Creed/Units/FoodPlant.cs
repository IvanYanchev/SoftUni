using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public abstract class FoodPlant : Plant
    {
        public FoodPlant(string id, int health, int growTime) 
            : base(id, health, growTime)
        {
        }

        public override void Water()
        {
            this.Health++;
        }

        public override void Wither()
        {
            this.Health -= 2;
        }
    }
}
