using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();

            bool areNotFountPythagoreanNumbers = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    for (int k = j; k < numbers.Count; k++)
                    {
                        if (numbers[i] * numbers[i] + numbers[j] * numbers[j] == numbers[k] * numbers[k])
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[i], numbers[j], numbers[k]);
                            areNotFountPythagoreanNumbers = false;
                        }
                    }
                }
            }
            if (areNotFountPythagoreanNumbers)
            {
                Console.WriteLine("No");
            }
        }
    }
}
