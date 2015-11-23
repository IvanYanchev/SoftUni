using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        internal decimal height;
        private MaterialType material;

        public decimal Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m");
                }
                this.height = value;
            }
        }

        public string Material
        {
            get { return this.material.ToString(); }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be empty, null or with less than 3 symbols");
                }
                this.model = value;
            }

        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00");
                }
                this.price = value;
            }
        }

        protected Furniture(string model, decimal price, decimal height, MaterialType material)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.material = material;
        }
    }
}