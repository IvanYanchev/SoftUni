using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;

        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public new decimal Height
        {
            get
            {
                if (this.IsConverted)
                {
                    return 0.10m;
                }
                else
                {
                    return this.height;
                }
            }
        }

        public ConvertibleChair(string model, decimal price, decimal height, MaterialType material, int numberOfLegs) 
            : base(model, price, height, material, numberOfLegs)
        {
            this.isConverted = false;
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }

        public override string ToString()
        {
            return string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                this.GetType().Name, 
                this.Model, 
                this.Material, 
                this.Price, 
                this.Height,
                this.NumberOfLegs,
                this.IsConverted ? "Converted" : "Normal");
        }
    }
}
