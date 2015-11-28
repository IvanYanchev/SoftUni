using System;
using System.Linq;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Ships;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            StarshipType starshipType = (StarshipType)Enum.Parse(typeof(StarshipType), commandArgs[1]);
            string shipName = commandArgs[2];
            StarSystem starSystem = this.GameEngine.Galaxy.GetStarSystemByName(commandArgs[3]);

            if (this.GameEngine.Starships.Any(ship => ship.Name == shipName))
            {
                Console.WriteLine("Ship with such name already exists");
            }
            else
            {
                IStarship starship = this.GameEngine.ShipFactory.CreateShip(starshipType, shipName, starSystem);
                for (int i = 4; i < commandArgs.Length; i++)
                {
                    EnhancementType enhancementType = (EnhancementType)Enum.Parse(typeof(EnhancementType), commandArgs[i]);
                    starship.AddEnhancement(this.GameEngine.EnhancementFactory.Create(enhancementType));
                }
                this.GameEngine.Starships.Add(starship);
                Console.WriteLine("Created {0} {1}", commandArgs[1], commandArgs[2]);
            }
        }
    }
}
