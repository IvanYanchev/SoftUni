using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private List<IFurniture> furnitures;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be empty, null or with less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set
            {
                if (value.Length < 10 && !value.All(s => char.IsDigit(s)))
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return furnitures.Find(m => m.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
        }

        public string Catalog()
        {
            StringBuilder catalog = new StringBuilder();
            catalog.Append(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            foreach (IFurniture furniture in this.Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model))
            {
                catalog.Append(string.Format("\n{0}", furniture));
            }

            return catalog.ToString();
        }
    }
}
