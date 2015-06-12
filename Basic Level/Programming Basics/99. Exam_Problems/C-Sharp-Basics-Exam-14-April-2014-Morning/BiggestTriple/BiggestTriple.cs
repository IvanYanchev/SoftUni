using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestTriple
{
    class BiggestTriple
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] inputNumbers = inputLine.Split(' ');
            int[] numbers = new int[inputNumbers.Length];
            int[] sum = new int[inputNumbers.Length / 3 + 1];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }
            int k = 0;
            int l = 0;
            while (true)
            {
                if (k * 3 + l >= inputNumbers.Length)
                {
                    break;
                }
                sum[k] = sum[k] + numbers[k * 3 + l];
                l++;
                if (l>2)
                {
                    l = 0;
                    k++;
                }
            }

            var index = sum.ToList().IndexOf(sum.Max());
            for (int i = 3 * index; i < 3 * index + 3; i++)
            {
                if (i < inputNumbers.Length)
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }
        }
    }
}
