using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
//The model and price are mandatory. All other values are optional.
//Define two separate classes: a class Laptop holding an instance of class Battery.
//Define several constructors that take different sets of arguments (full laptop + battery information or only part of it). Use proper variable types.
//Add a method in the Laptop class that displays information about the given instance
//Tip: override the ToString() method
//Put validation in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative. Throw exceptions when improper data is entered.


namespace _02_LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int? ram; // in GB
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price; // in lv.

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid model.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid manufacturer.");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid processor type.");
                }
                this.processor = value;
            }
        }

        public int? Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Invalid amount of RAM.");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid graphics card type.");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid HDD type.");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid HDD type.");
                }
                this.screen = value;
            }
        }

        public Battery Battery {get; set;}

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price.");
                }
                this.price = value;
            }
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, int? ram = null, string graphicsCard = null, string hdd = null, string screen = null, Battery battery = null )
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public override string ToString()
        {
            string description = string.Format("Model: {0}\n\r", this.Model);

            if (!string.IsNullOrEmpty(this.Manufacturer))
            {
                description += string.Format("Manufacturer: {0}\n\r", this.Manufacturer);
            }
            if (!string.IsNullOrEmpty(this.Processor))
            {
                description += string.Format("Processor: {0}\n\r", this.Processor);
            }
            if (Ram != null)
            {
                description += string.Format("Ram: {0} GB\n\r", this.Ram);
            }
            if (!string.IsNullOrEmpty(this.GraphicsCard))
            {
                description += string.Format("GraphicsCard: {0}\n\r", this.GraphicsCard);
            }
            if (!string.IsNullOrEmpty(this.Hdd))
            {
                description += string.Format("Hdd: {0}\n\r", this.Hdd);
            }
            if (!string.IsNullOrEmpty(this.Screen))
            {
                description += string.Format("Screen: {0}\n\r", this.Screen);
            }
            if (this.Battery != null)
            {
                description += string.Format("{0}\n\r", this.Battery);
            }

            description += string.Format("Price: {0} lv.\n\r", this.Price);

            return description;
        }
    }
}
