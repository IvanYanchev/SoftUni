using System;
using System.Collections.Generic;
using ClashOfKings.Attributes;
using ClashOfKings.Contracts;
using ClashOfKings.Exceptions;
using ClashOfKings.Models.Armies.AirForce;
using ClashOfKings.Models.Armies.Cavalry;
using ClashOfKings.Models.Armies.Infantry;

namespace ClashOfKings.Models.Commands
{
    [Command]
    public class CreateUnitCommand : Command
    {
        public CreateUnitCommand(IGameEngine engine)
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            IMilitaryUnit unit = null;

            int numberOfUnits = int.Parse(commandParams[0]);
            string unitType = commandParams[1];
            switch (unitType)
            {
                case "Dragon":
                    unit = new Dragon();
                    break;
                case "Dothraki":
                    unit = new Dothraki();
                    break;
                case "Horseman":
                    unit = new Horseman();
                    break;
                case "Knight":
                    unit = new Knight();
                    break;
                case "FootSoldier":
                    unit = new FootSoldier();
                    break;
                case "SellSword":
                    unit = new SellSword();
                    break;
                case "Unsullied":
                    unit = new Unsullied();
                    break;
            }

            ICity city = this.Engine.Continent.GetCityByName(commandParams[2]);

            if (numberOfUnits < 0)
            {
                this.Engine.Render("Number of units should be non-negative");
            }
            else if (city == null)
            {
                throw new NonExistentCityException("City does not exist");
            }
            else if (city.AvailableUnitCapacity(unit.Type) < unit.HousingSpacesRequired * numberOfUnits)
            {
                this.Engine.Render(
                    "City {0} does not have enough housing spaces to accommodate {1} units of {2}",
                    city.Name,
                    numberOfUnits,
                    unitType);
            }
            else if (city.ControllingHouse.TreasuryAmount < unit.TrainingCost * numberOfUnits)
            {
                this.Engine.Render(
                    "House {0} does not have enough funds to train {1} units of {2}",
                    city.ControllingHouse.Name,
                    numberOfUnits,
                    unitType);
            }
            else
            {
                IMilitaryUnit[] units = new IMilitaryUnit[numberOfUnits];
                for (int i = 0; i < units.Length; i++)
                {
                    units[i] = unit;
                }
                city.ControllingHouse.TreasuryAmount -= unit.TrainingCost * numberOfUnits;
                city.AddUnits(units);
                this.Engine.Render(
                    "Successfully added {0} units of {1} to city {2}",
                    numberOfUnits,
                    unitType,
                    city.Name);
            }
        }
    }
}
