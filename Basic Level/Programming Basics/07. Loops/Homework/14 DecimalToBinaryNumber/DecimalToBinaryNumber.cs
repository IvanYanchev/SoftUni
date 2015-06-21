using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string bits = string.Empty;

            do
            {
                bits = n % 2 + bits;
                n = n / 2;

            } while (n != 0);

            Console.WriteLine(bits);
        }
    }
}
