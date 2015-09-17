using System;

namespace SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersAsStrings = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[numbersAsStrings.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }

            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
