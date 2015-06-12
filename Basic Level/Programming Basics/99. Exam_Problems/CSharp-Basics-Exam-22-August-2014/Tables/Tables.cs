using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            int sumLegs = 0;
            for (int i = 1; i <= 4; i++)
            {
                sumLegs += int.Parse(Console.ReadLine()) * i;
            }
            int tableTops = int.Parse(Console.ReadLine());
            int tablesToBeMade = int.Parse(Console.ReadLine());

            int tablesMade = Math.Min(tableTops, sumLegs / 4);

            int diff = tablesMade - tablesToBeMade;

            if (diff > 0)
            {
                Console.WriteLine("more: {0}", diff);
                Console.WriteLine("tops left: {0}, legs left: {1}", tableTops - tablesToBeMade, sumLegs - tablesToBeMade * 4);
            }
            else if (diff == 0)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesToBeMade);
            }
            else
            {
                Console.WriteLine("less: {0}", diff);
                int topsNeeded = tablesToBeMade - tableTops > 0 ? tablesToBeMade - tableTops : 0;
                int legsNeeded = tablesToBeMade * 4 - sumLegs > 0 ? tablesToBeMade * 4 - sumLegs : 0;
                Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
            }
        }
    }
}
