using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class BiggerNumber
    {
        static int GetMax(int a, int b)
        {
            int bigger = a;
            if (b > a)
            {
                bigger = b;
            }
            return bigger;
        }

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }
    }
}
