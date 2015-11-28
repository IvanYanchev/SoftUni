using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            StarSystem starSystem = this.GameEngine.Galaxy.GetStarSystemByName(commandArgs[1]);
            StringBuilder report = new StringBuilder();
            report.AppendLine("Intact ships:");

            var intactShips = GameEngine.Starships
                .Where(x => x.Health > 0 && x.Location == starSystem)
                .OrderByDescending(x => x.Health)
                .ThenByDescending(x => x.Shields);

            if (!intactShips.Any())
            {
                report.AppendLine("N/A");
            }
            else
            {
                foreach (IStarship ship in intactShips)
                {
                    report.AppendLine(ship.ToString());
                }
            }

            report.Append("Destroyed ships:");

            var destroyedShips = GameEngine.Starships
                .Where(x => x.Health <= 0 && x.Location == starSystem)
                .OrderBy(x => x.Name);

            if (!destroyedShips.Any())
            {
                report.AppendLine().Append("N/A");
            }
            else
            {
                foreach (IStarship ship in destroyedShips)
                {
                    report.AppendLine().Append(ship);
                }
            }

            Console.WriteLine(report);
        }
    }
}
