using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSums
{
    class SubsetSums
    {
        static void SubsetSumAndAdd(List<int> set, List<List<int>> list, int mask, int n)
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
                subset.Sort();
                list.Add(subset);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "0 11 1 10 5 6 3 4 7 2";
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
            List<List<int>> listOfSubsets = new List<List<int>>();

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
                SubsetSumAndAdd(numbers, listOfSubsets, mask, n);
            }

            var result = listOfSubsets.OrderBy(x => x.Count);
            foreach (var item in result)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", item), item.Sum());
            }
        }
    }
}
