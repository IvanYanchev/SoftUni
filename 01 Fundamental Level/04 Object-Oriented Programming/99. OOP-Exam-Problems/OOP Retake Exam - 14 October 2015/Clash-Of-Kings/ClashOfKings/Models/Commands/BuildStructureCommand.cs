using ClashOfKings.Attributes;
using ClashOfKings.Contracts;
using ClashOfKings.Exceptions;
using ClashOfKings.Models.Structures;

namespace ClashOfKings.Models.Commands
{
    [Command]
    public class BuildStructureCommand : Command
    {
        public BuildStructureCommand(IGameEngine engine)
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            ICity city = this.Engine.Continent.GetCityByName(commandParams[1]);

            if (city == null)
            {
                throw new NonExistentCityException("City does not exist");
            }

            IArmyStructure structure = null;
            switch (commandParams[0])
            {
                case "Barracks":
                    structure = new Barracks();
                    break;
                case "DragonLair":
                    structure = new DragonLair();
                    break;
                case "Stable":
                    structure = new Stable();
                    break;
            }

            if (city.CityType < structure.RequiredCityType)
            {
                throw new InsufficientCitySizeException("Structure requires a more advanced city");
            }
            else if (city.ControllingHouse.TreasuryAmount < structure.BuildCost)
            {
                throw new InsufficientFundsException(string.Format(
                    "House {0} doesn't have sufficient funds to build {1}",
                    city.ControllingHouse.Name,
                    structure));
            }
            else
            {
                city.ControllingHouse.TreasuryAmount -= structure.BuildCost;
                city.AddArmyStructure(structure);
                this.Engine.Render(
                    "Successfully built {0} in {1}", 
                    structure, 
                    city.Name);
            }
        }
    }
}
