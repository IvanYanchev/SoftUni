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
            string matchWord = "is";
            string text = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";

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