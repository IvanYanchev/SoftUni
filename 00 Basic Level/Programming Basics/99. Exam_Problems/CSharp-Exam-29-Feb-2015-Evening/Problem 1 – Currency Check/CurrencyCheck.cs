using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Currency_Check
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            uint r = uint.Parse(Console.ReadLine()); //	The number r – amount of rubles Te4o has to pay for the game at the Russian site.
            uint d = uint.Parse(Console.ReadLine()); //	The number d – amount of dollars Te4o has to pay for the game at the American site.
            uint e = uint.Parse(Console.ReadLine()); //	The number e – amount of euro Te4o has to pay for the game at the official site.
            uint b = uint.Parse(Console.ReadLine()); //	The number b – amount of leva Te4o has to pay for the special offer at B.
            uint m = uint.Parse(Console.ReadLine()); //	The number m – amount of leva Te4o has to pay for the game at M's site.

            List<double> prices = new List<double>()
            {
                r * 3.5 / 100,
                d * 1.5,
                e * 1.95,
                b / 2d,
                m,
            };

            Console.WriteLine("{0:F2}", prices.Min());

        }
    }
}
