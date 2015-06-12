using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckNumbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            bool areNotFoundStuckNumbers = true;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        for (int d = 0; d < numbers.Length; d++)
                        {
                            if (a != b && a != c && a != d && b != c && b != d && c != d)
                            {
                                string left = "" + numbers[a] + numbers[b];
                                string right = "" + numbers[c] + numbers[d];
                                if (left == right)
                                {
                                    Console.WriteLine("{0}|{1}=={2}|{3}", numbers[a], numbers[b], numbers[c], numbers[d]);
                                    areNotFoundStuckNumbers = false;
                                }
                            }
                        }
                    }
                }
            }
            if (areNotFoundStuckNumbers)
            {
                Console.WriteLine("No");
            }
        }
    }
}