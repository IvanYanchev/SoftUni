using System;
using System.Linq;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("{0:F2}", numbers.Average());

        }
    }