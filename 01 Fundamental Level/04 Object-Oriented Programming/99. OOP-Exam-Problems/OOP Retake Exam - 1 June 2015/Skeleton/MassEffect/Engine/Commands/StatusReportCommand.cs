using System;
using System.Linq;
using System.Text;
using MassEffect.GameObjects.Ships;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            IStarship starship = this.GameEngine.Starships.FirstOrDefault(ship => ship.Name == commandArgs[1]);

            Console.WriteLine(starship);
        }
    }
}
