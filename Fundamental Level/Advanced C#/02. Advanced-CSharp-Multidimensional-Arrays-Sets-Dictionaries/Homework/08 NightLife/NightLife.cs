using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightLife
{
    class NightLife
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> nightLifeProgram = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "END")
                {
                    break;
                }
                string city = inputString.Split(';')[0];
                string venue = inputString.Split(';')[1];
                string performer = inputString.Split(';')[2];

                if (!nightLifeProgram.ContainsKey(city))
                {
                    nightLifeProgram.Add(city, new Dictionary<string, List<string>>() { { venue, new List<string>() { performer, } } });
                }
                else if (!nightLifeProgram[city].ContainsKey(venue))
                {
                    nightLifeProgram[city].Add(venue, new List<string>() { performer, });
                }
                else if (!nightLifeProgram[city][venue].Contains(performer))
                {
                    nightLifeProgram[city][venue].Add(performer);
                }
            }

            foreach (var city in nightLifeProgram)
            {
                Console.WriteLine(city.Key);
                foreach (var venue in city.Value)
                {
                    Console.Write("->{0}: {1}", venue.Key, string.Join(", ", venue.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
