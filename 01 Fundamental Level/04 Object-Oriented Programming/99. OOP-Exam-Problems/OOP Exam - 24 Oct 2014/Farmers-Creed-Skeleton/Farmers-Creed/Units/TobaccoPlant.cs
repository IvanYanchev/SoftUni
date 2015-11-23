using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public class TobaccoPlant : Plant
    {
        private const int TobaccoPlantHealth = 12;
        private const int TabaccoPlantGrowTime = 4;

        public TobaccoPlant(string id) 
            : base(id, TobaccoPlant.TobaccoPlantHealth, TobaccoPlant.TabaccoPlantGrowTime)
        {
        }

        public override void Grow()
        {
            if (this.GrowTime > 0)
            {
                this.GrowTime -= 2;
            }
        }

        public override Product GetProduct()
        {
            if (this.IsAlive && this.HasGrown)
            {
                return new Product(this.Id + "Product", ProductType.Tobacco, 10);
            }
            return null;
        }
    }
}
