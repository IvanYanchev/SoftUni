using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TrailingZeroesInNFactorel
{
    class TrailingZeroesInNFactorel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorel = 1;

            for (int i = 1; i <= n; i++)
            {
                factorel *= i;
            }

            string str = factorel.ToString();

            // VARIANT 1
            //char[] nums = str.ToCharArray(); 
            //int count = 0;
            //for (int j = nums.Length - 1; j >= 0; j--)
            //{
            //    if (nums[j] != '0')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        count = count + 1;
            //    }
            //}
            //Console.WriteLine(count);

            // VARIANT 2
            string strWithoutTrailingZeros = str.TrimEnd('0');
            int trailingZerosLenght = str.Length - strWithoutTrailingZeros.Length;
            Console.WriteLine(trailingZerosLenght);
        }
    }
}
