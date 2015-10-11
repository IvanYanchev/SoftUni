using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            int numbersCount = 5;

            double[] numbers = new double[numbersCount];

            double max = double.MinValue;

            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());

                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("The biggest number is: {0}", max);
        }
    }
}
