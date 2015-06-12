using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static double GetReversednumber(double n)
        {
            string numStr = n.ToString();
            StringBuilder reversed = new StringBuilder();
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                reversed.Append(numStr[i]);
            }
            string mun = reversed.ToString();
            return double.Parse(mun);
        }

        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversednumber(num));

        }
    }
}
