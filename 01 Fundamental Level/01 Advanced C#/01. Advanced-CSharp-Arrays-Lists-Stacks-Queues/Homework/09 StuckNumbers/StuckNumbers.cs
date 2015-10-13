using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckNumbers
{
    class StuckNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
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
                                StringBuilder left = new StringBuilder();
                                left.Append(numbers[a]);
                                left.Append(numbers[b]);

                                StringBuilder right = new StringBuilder();
                                right.Append(numbers[c]);
                                right.Append(numbers[d]);

                                if (left.Equals(right))
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