using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfKNumbers
{
    class SequenceOfKNumbers
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            string[] inputNumbers = inputLine.Split(' ');
            List<string> numbers = inputNumbers.ToList();
            int index = 0;
            bool isEqual = true;
            while (true)
            {
                if (index + k - 1 >= numbers.Count)
                {
                    break;
                }
                else
                {
                    for (int i = 1; i < k; i++)
                    {
                        if (numbers[index] != numbers[index + i])
                        {
                            isEqual = false;
                        }
                    }
                    if (isEqual)
                    {
                        for (int i = 0; i < k; i++)
                        {
                            numbers.RemoveAt(index);
                        }
                    }
                    else
                    {
                        index++;
                        isEqual = true;
                    }
                }
            }
            foreach (var num in numbers)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
