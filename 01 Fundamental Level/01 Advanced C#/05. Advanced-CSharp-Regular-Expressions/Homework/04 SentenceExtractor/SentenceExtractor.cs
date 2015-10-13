using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string matchWord = Console.ReadLine();

            string text = Console.ReadLine();

            string pattern = @"[A-Z0-9][^\.!?]*[\.!?]";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string myString = match.ToString().ToLower();
                if (myString.Contains(matchWord))
                {
                    Console.WriteLine(myString);
                }
            }
        }
    }
}