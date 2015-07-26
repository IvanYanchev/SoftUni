using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToUpper();

            string pattern = @"(\D+?)(\d+)";

            MatchCollection matches = Regex.Matches(inputString, pattern);

            List<char> uniqeSymbols = new List<char>();

            foreach (Match match in matches)
            {
                string message = match.Groups[1].Value;
                int repetition = int.Parse(match.Groups[2].Value);

                if (repetition > 0)
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        if (!uniqeSymbols.Contains(message[i]))
                        {
                            uniqeSymbols.Add(message[i]);
                        }
                    }
                }
            }

            Console.WriteLine("Unique symbols used: {0}", uniqeSymbols.Count);

            foreach (Match match in matches)
            {
                string message = match.Groups[1].Value;
                int repetition = int.Parse(match.Groups[2].Value);

                StringBuilder output = new StringBuilder();

                for (int i = 0; i < repetition; i++)
                {
                   output.Append(message);
                }

                Console.Write(output.ToString());
            }
        }
    }
}
