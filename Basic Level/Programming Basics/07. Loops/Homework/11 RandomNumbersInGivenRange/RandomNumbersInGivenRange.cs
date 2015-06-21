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
            Console.Write("Please enter integer n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter integer min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter integer max: ");
            int max = int.Parse(Console.ReadLine());


            Random number = new Random();

            for (int i = 0; i < n; i++)
			{
			    Console.Write("{0} ", number.Next(min, max + 1));
			}
        }
    }
}
