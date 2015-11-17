using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Component
    {
        private string name = null;
        private string details = null;
        private double price = 0;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name could not be null. Please enter valid name.");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("The price coud not be less or equal to 0. Please enter valid price.");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public Component()
        {

        }

        public Component(string componentName, double componentPrice) : this ()
        {
            this.Name = componentName;
            this.Price = componentPrice;
        }

        public Component(string componentName, double componentPrice, string componentDetails = null) : this (componentName, componentPrice)
        {
            this.Details = componentDetails;
        }

        public override string ToString()
        {
            return string.Format("Component name: {0}, component price: {1}", this.name, this.price);
        }
    }
}
