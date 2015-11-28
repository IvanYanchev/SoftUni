using System;
using System.Linq;
using ClashOfKings.Exceptions;

namespace ClashOfKings.Models.Commands
{
    using Attributes;
    using Contracts;

    [Command]
    public class UpgradeCityCommand : Command
    {
        public UpgradeCityCommand(IGameEngine engine)
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            ICity city = this.Engine.Continent.GetCityByName(commandParams[0]);

            try
            {
                city.ControllingHouse.UpgradeCity(city);
                this.Engine.Render(
                    "City {0} successfully upgraded to {1}",
                    city.Name,
                    city.CityType);
            }
            catch (GameException ex)
            {
                this.Engine.Render(ex.Message);
            }



            //if (city == null)
            //{
            //    throw new NonExistentCityException("City does not exist");
            //}
            //else if (city.CityType == CityType.Capital)
            //{
            //    this.Engine.Render(
            //        "City {0} is at the maximum level and cannot be upgraded further",
            //        city.Name);
            //}
            //else if (city.ControllingHouse.TreasuryAmount < city.UpgradeCost && city.ControllingHouse.ControlledCities.ToList().Count < 10)
            //{
            //    throw new NotEnoughProvisionsException(string.Format(
            //        "House {0} has insufficient funds to upgrade {1}",
            //        city.ControllingHouse.Name,
            //        city.Name));
            //}
            //else
            //{
            //    city.ControllingHouse.UpgradeCity(city);
            //    this.Engine.Render(
            //        "City {0} successfully upgraded to {1}",
            //        city.Name,
            //        city.CityType);
            //}
        }
    }
}