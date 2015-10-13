using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFactors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            uint fg = uint.Parse(Console.ReadLine());
            uint fga = uint.Parse(Console.ReadLine());
            uint threep = uint.Parse(Console.ReadLine());
            uint tov = uint.Parse(Console.ReadLine());
            uint orb = uint.Parse(Console.ReadLine());
            uint opporb = uint.Parse(Console.ReadLine());
            uint ft = uint.Parse(Console.ReadLine());
            uint fta = uint.Parse(Console.ReadLine());

            double efgPerc = (fg + 0.5 * threep) / fga;
            double tovPerc = (double)tov / (fga + 0.44 * fta + tov);
            double orbPerc = (double)orb / (orb + opporb);
            double ftPerc = (double)ft / (double)fga;

            Console.WriteLine("eFG% {0:F3}", efgPerc);
            Console.WriteLine("TOV% {0:F3}", tovPerc);
            Console.WriteLine("ORB% {0:F3}", orbPerc);
            Console.WriteLine("FT% {0:F3}", ftPerc);
        }
    }
}
