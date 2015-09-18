using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double reversed = GetReversednumber(num);
            Console.WriteLine(reversed);

        }

        static double GetReversednumber(double n)
        {
            string numStr = n.ToString();
            StringBuilder reversed = new StringBuilder();
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                reversed.Append(numStr[i]);
            }

            string mun = reversed.ToString();
            if (mun.Contains("-"))
            {
                mun = mun.Remove(mun.Length - 1);
            }

            return double.Parse(mun);
        }

    }
}
