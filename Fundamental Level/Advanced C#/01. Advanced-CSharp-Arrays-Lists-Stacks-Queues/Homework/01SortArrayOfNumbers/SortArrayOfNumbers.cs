using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] numAsString = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[numAsString.Length];
            for (int i = 0; i < numAsString.Length; i++)
            {
                numbers[i] = int.Parse(numAsString[i]);
            }
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
