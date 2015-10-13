using System;
using System.Linq;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int weight = 0;
        bool isNotFoundLettersSequence = true;

        string[] letters = { "a", "b", "c", "d", "e" };
        foreach (var firstLetter in letters)
        {
            foreach (var secondLetter in letters)
            {
                foreach (var thirdLetter in letters)
                {
                    foreach (var fourthLetter in letters)
                    {
                        foreach (var fifthLetter in letters)
                        {
                            string lettersSequence = firstLetter + secondLetter + thirdLetter + fourthLetter + fifthLetter;
                            char[] noduplicates = lettersSequence.Distinct().ToArray();
                            int result = 0;
                            for (int i = 1; i <= noduplicates.Length; i++)
                            {
                                switch (noduplicates[i - 1])
                                {
                                    case 'a': weight = 5; break;
                                    case 'b': weight = -12; break;
                                    case 'c': weight = 47; break;
                                    case 'd': weight = 7; break;
                                    case 'e': weight = -32; break;
                                }
                                result = result + i * weight;
                            }
                            if (result >= start && result <= end)
                            {
                                Console.Write("{0} ", lettersSequence);
                                isNotFoundLettersSequence = false;

                            }
                        }
                    }
                }
            }
        }
        if (isNotFoundLettersSequence) Console.Write("No");
    }
}