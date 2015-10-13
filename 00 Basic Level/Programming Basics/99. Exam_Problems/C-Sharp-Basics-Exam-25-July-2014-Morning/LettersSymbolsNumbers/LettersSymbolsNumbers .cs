using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersSymbolsNumbers
{
    class LettersSymbolsNumbers 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLetters = 0;
            int sumNumbers = 0;
            int sumSymbols = 0;

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                char[] ch = inputString.ToCharArray();
                foreach (var character in ch)
                {
                    if (character >= 65 && character <= 90)
                    {
                        sumLetters = sumLetters + (character - 64) * 10;
                    }
                    else if (character >= 97 && character <= 122)
                    {
                        sumLetters += (character - 96) * 10;
                    }
                    else if (character >= 48 && character <= 57)
                    {
                        sumNumbers += (character - 48) * 20;
                    }
                    else if ((character >= 33 && character <=47) ||
                             (character >= 58 && character <=64) ||
                             (character >= 91 && character <=96) ||
                             (character >= 123 && character <=126))
                    {
                        sumSymbols += 200;
                    }
                }
            }
            Console.WriteLine(sumLetters);
            Console.WriteLine(sumNumbers);
            Console.WriteLine(sumSymbols);
        }
    }
}
