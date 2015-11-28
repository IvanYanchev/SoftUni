using System;
using System.Linq;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            IStarship attackerShip = this.GameEngine.Starships.FirstOrDefault(ship => ship.Name == commandArgs[1]);
            IStarship targetShip = this.GameEngine.Starships.FirstOrDefault(ship => ship.Name == commandArgs[2]);

            if (attackerShip == null || targetShip == null || attackerShip.Location != targetShip.Location)
            {
                throw new LocationOutOfRangeException("No such ship in star system");
            }

            if (attackerShip.Health <= 0 || targetShip.Health <= 0)
            {
                throw new ShipException("Ship is destroyed");
            }

            attackerShip.ProduceAttack().Hit(targetShip);

            Console.WriteLine("{0} attacked {1}", attackerShip.Name, targetShip.Name);

            if (targetShip.Health <= 0)
            {
                Console.WriteLine("{0} has been destroyed", targetShip.Name);
            }
        }
    }
}
