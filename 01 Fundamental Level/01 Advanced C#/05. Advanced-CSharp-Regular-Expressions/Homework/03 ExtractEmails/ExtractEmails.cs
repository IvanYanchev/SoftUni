using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //string input = File.ReadAllText("../../SomeEmailsList.txt");

            string pattern = @"(?<=\s|^)[a-zA-Z0-9]+([.-]?\w+)+@[a-z]+([.-]?[a-z])+[.][a-z]+\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

            //Console.WriteLine(matches.Count);
        }
    }
}
