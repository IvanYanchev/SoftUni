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

                string[] words = inputText.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    string upperCaseWordPattern = @"(\b|\d)([A-Z]+)(\b|\d)";
                    MatchCollection upperCaseWords = Regex.Matches(words[i], upperCaseWordPattern);
                    foreach (Match word in upperCaseWords)
                    {
                        string replaceWord = string.Join("", word.Groups[2].Value.Reverse());
                        if (replaceWord == word.Groups[2].Value)
                        {
                            replaceWord = string.Empty;
                            for (int j = 0; j < word.Groups[2].Value.Length; j++)
                            {
                                replaceWord += new string(word.Groups[2].Value[j], 2);
                            }
                        }
                        words[i] = Regex.Replace(words[i], word.Groups[2].Value, replaceWord);
                    }
                }
                Console.WriteLine(SecurityElement.Escape(string.Join(" ", words)));
            }
        }
    }
}
