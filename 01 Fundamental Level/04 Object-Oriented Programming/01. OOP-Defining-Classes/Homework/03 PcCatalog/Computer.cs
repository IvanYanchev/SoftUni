using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Computer
    {
        private string name = null;
        private Component[] components = null;
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

        public Component[] Components
        {
            get
            {
                return this.components;
            }
            set
            {
                this.components = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
        }

        public Computer(string compName)
        {
            this.Name = compName;
        }

        public Computer(string compName, params Component[] compComponents) : this (compName)
        {
            this.Components = compComponents;
            foreach (var component in Components)
            {
                this.price += component.Price;
            }
        }

        public void PrintInfo()
        {
            string header = new string('-', 62) + "\n";
            string description = header;
            string compName = string.Format(" Computer: {0}", this.name);
            description += string.Format("|{0,-60}|\n\r", compName);
            description += header;
            description += string.Format("|{0,-40}|{1,-19}|\n\r", " Components", " Price, USD");
            description += header;

            if (this.components != null)
            {
                foreach (var component in components)
                {
                    description += string.Format("| {0,-39}| {1,-18:0.00}|\n\r", component.Name, component.Price);
                }
                description += header;
            }
           
            if (components != null)
            {
                description += string.Format("| {0,-39}| {1,-18:0.00}|\n\r", "Total price", this.price);
                description += header;
            }

            Console.WriteLine(description);
        }
    }
}
