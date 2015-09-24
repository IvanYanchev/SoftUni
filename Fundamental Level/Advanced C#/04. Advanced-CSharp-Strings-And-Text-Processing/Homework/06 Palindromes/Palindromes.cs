using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> palindromes = new List<string>();

            foreach (var word in input.Split(new char[]{'.', ',', ' ', '!', '?'}, StringSplitOptions.RemoveEmptyEntries))
            {
                bool wordIsPalindrome = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        wordIsPalindrome = false;
                        break;
                    }
                }
                if (wordIsPalindrome && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
