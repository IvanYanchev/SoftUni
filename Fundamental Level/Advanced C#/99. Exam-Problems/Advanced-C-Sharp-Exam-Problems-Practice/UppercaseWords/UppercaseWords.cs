using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UppercaseWords
{
    class UppercaseWords
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }
                string upperCaseWordPattern = @"(\b|\d)([A-Z]+)(\b|\d)";
                MatchCollection upperCaseWords = Regex.Matches(inputText, upperCaseWordPattern);
                
                string outputText = inputText;
                foreach (var word in upperCaseWords.OfType<Match>().Select(x => x.Groups[2].Value).Distinct())
                {
                    string replaceWord = string.Join("", word.Reverse());
                    if (replaceWord == word)
                    {
                        replaceWord = string.Empty;
                        for (int i = 0; i < word.Length; i++)
                        {
                            replaceWord += new string(word[i], 2);
                        }
                    }
                    outputText = Regex.Replace(outputText, word, replaceWord);
                }

                Console.WriteLine(SecurityElement.Escape(outputText));
            }

        }
    }
}
