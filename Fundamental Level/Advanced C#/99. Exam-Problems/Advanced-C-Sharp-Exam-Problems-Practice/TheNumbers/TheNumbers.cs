using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TheNumbers
{
    class TheNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string numbersPattern = @"\d+";

            MatchCollection numbersDec = Regex.Matches(input, numbersPattern);

            List<string> numbersHex = new List<string>();

            foreach (Match number in numbersDec)
            {
                string hex = Convert.ToString(int.Parse(number.Value), 16);
                hex = string.Format("{0}{1}{2}", "0x", new string('0', 4 - hex.Length), hex.ToUpper());
                numbersHex.Add(hex);
            }

            Console.WriteLine(string.Join("-", numbersHex));
        }
    }
}