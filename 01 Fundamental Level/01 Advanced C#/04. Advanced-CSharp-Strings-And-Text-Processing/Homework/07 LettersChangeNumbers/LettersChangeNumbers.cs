﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            double sum = 0d;

            foreach (var sequence in inputLine.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)) 
            {
                char letterStart = sequence[0];
                char letterEnd = sequence[sequence.Length - 1];
                int number = int.Parse(sequence.Substring(1, sequence.Length - 2));
                
                if (char.IsUpper(letterStart))
                {
                    sum = sum + number / (letterStart - 'A' + 1d);
                }
                else
                {
                    sum = sum + number * (letterStart - 'a' + 1d);
                }
                if (char.IsUpper(letterEnd))
                {
                    sum = sum - (letterEnd - 'A' + 1d);
                }
                else
	            {
                    sum = sum + (letterEnd - 'a' + 1d);
	            }
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
