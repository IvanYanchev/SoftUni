using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string model, decimal price, decimal height, MaterialType material, int numberOfLegs) 
            : base(model, price, height, material, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
