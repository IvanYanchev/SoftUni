using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _04.Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> agregatedData = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "report")
                {
                    break;
                }

                string[] inputArguments = input.Split('|');
                string city = inputArguments[0];
                string country = inputArguments[1];
                long population = long.Parse(inputArguments[2]);

                if (!agregatedData.ContainsKey(country))
                {
                    agregatedData.Add(country, new Dictionary<string, long>());
                }

                agregatedData[country].Add(city, population);
            }

            foreach (var country in agregatedData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                BigInteger totalCountryPopulation = country.Value.Values.Sum();

                Console.WriteLine("{0} (total population: {1})", country.Key, totalCountryPopulation);

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
