using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumUsingSelectionSort
{
    class SortArrayOfNumbersUsingSelectionSort
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            int[] numbers = inputLine.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}