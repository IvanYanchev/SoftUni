using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClashOfKings.Contracts;

namespace ClashOfKings.Models
{
    public class GreatHouse : House
    {
        public GreatHouse(string name, decimal initialTreasuryAmount, IEnumerable<ICity> controlledCities) 
            : base(name, initialTreasuryAmount)
        {
            foreach (ICity controlledCity in controlledCities)
            {
                this.AddCityToHouse(controlledCity);
            }
        }

        public override decimal TreasuryAmount { get; set; }

        public override void UpgradeCity(ICity city)
        {
            if (city == null)
            {
                throw new ArgumentNullException(string.Format("Specified city does not exist or is not controlled by house {0}", this.Name));
            }

            city.Upgrade();
        }

        public override string Print()
        {
            return "Great " + base.Print();
        }
    }
}
