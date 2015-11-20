using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.Error.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}
