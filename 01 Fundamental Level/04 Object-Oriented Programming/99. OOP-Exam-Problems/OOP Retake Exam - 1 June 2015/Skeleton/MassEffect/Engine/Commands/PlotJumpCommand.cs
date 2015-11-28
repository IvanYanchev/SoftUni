using System;
using System.Linq;
using MassEffect.Exceptions;
using MassEffect.GameObjects.Locations;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            IStarship starship = this.GameEngine.Starships.FirstOrDefault(ship => ship.Name == commandArgs[1]);
            StarSystem location = starship.Location;
            StarSystem destination = this.GameEngine.Galaxy.GetStarSystemByName(commandArgs[2]);

            if (starship.Health <= 0)
            {
                throw new ShipException("Ship is destroyed");
            }

            if (location == destination)
            {
                throw new LocationOutOfRangeException(string.Format("Ship is already in {0}", destination.Name));
            }

            try
            {
                this.GameEngine.Galaxy.TravelTo(starship, destination);
                Console.WriteLine("{0} jumped from {1} to {2}", starship.Name, location.Name, destination.Name);
            }
            catch (ShipException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
