using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = input;

            for (char ch = 'a'; ch <= 'z'; ch++)
			{
			    string pattern = ch + "+";

                Regex regex = new Regex(pattern);

                output = regex.Replace(output, ch.ToString());
			}

            Console.WriteLine(output);
        }
    }
}