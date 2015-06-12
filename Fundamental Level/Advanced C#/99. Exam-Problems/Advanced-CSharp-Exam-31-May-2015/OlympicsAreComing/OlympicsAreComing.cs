using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicsAreComing
{
    class OlympicsAreComing
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> ratingList = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }
                string athlete = input.Split('|')[0];
                athlete = string.Join(" ", athlete.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries));
                string country = input.Split('|')[1];
                country = string.Join(" ", country.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries));

                if (!ratingList.ContainsKey(country))
                {
                    ratingList.Add(country, new Dictionary<string, int>() { { athlete, 1 } });
                }
                else if (!ratingList[country].ContainsKey(athlete))
                {
                    ratingList[country].Add(athlete, 1);
                }
                else
                {
                    ratingList[country][athlete]++;
                }
            }

            //var result = ratingList.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var country in ratingList.OrderByDescending(x => x.Value.Values.Sum()))
            {
                int sumWins = 0;
                foreach (var athlete in country.Value)
                {
                    sumWins += athlete.Value;
                }
                Console.WriteLine("{0} ({1} participants): {2} wins", country.Key, country.Value.Count, sumWins);
            }
        }
    }
}
