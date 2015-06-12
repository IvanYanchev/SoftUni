using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Power
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(numberPower(number, power));
        }

        static double numberPower(double num, int pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
