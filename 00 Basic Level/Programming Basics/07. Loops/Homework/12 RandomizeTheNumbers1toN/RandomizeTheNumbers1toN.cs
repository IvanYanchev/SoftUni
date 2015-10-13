using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random ran = new Random();

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
			{
			    numbers.Add(i+1);
			}

            for (int i = 0; i < n; i++)
            {
                int index = ran.Next(0, numbers.Count);
                Console.Write("{0} ", numbers[index]);
                numbers.Remove(numbers[index]);
            }
        }
    }
}
