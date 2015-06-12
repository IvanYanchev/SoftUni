using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextTransformer
{
    class TextTransformer
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "burp")
                {
                    break;
                }
                sb.Append(inputLine);
            }

            string text = sb.ToString();
            text = Regex.Replace(text, @"\s{2,}", " ");

            string pattern = @"([$%&'])(.+?)(\1)";

            MatchCollection matches = Regex.Matches(text, pattern);

            List<string> outputText = new List<string>();
            foreach (Match match in matches)
            {
                string word = match.Groups[2].Value;
                string specialSymbol = match.Groups[1].Value;
                int weight = GetWeight(specialSymbol[0]);
                string transformedWord = string.Empty;
                for (int i = 0; i < word.Length; i += 2)
                {
                    char chEven = (char)(word[i] + weight);
                    transformedWord += chEven;
                    if ((i + 1) < word.Length)
                    {
                        char chOdd = (char)(word[i + 1] - weight);
                        transformedWord += chOdd;
                    } 
                }
                outputText.Add(transformedWord);
            }
            Console.WriteLine(string.Join(" ", outputText));
        }

        static int GetWeight(char symbol)
        {
            switch (symbol)
            {
                case '$': return 1;
                case '%': return 2;
                case '&': return 3;
                case '\'': return 4;
                default: return 0;
            }
        }
    }
}
