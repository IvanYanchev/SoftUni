using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSums
{
    class SubsetSums
    {
        static void SubsetSumAndPrint(List<int> set, int mask, int n)
        {
            List<int> subset = new List<int>();
            for (int bitPosition = 0; bitPosition < 32; bitPosition++)
            {
                if ((mask & 1 << bitPosition) >> bitPosition == 1 && bitPosition < set.Count)
                {
                    subset.Add(set[bitPosition]);
                }
            }
            if (subset.Sum() == n)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", subset), subset.Sum());
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "0 11 1 10 5 6 3 4 7 2";
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.Remove(numbers[j]);
                    }
                }
            }
            for (int mask = 0; mask < Math.Pow(2, numbers.Count); mask++)
            {
                SubsetSumAndPrint(numbers, mask, n);
            }
        }
    }
}
