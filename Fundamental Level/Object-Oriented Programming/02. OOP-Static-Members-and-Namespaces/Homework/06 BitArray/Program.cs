using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitArray
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Please enter some really big integer: ");
            //string input = Console.ReadLine();
            //BigInteger number = 0;
            //bool isParsable = BigInteger.TryParse(input, out number);
            //if (isParsable)
            //{
            //    BitArray myNumber = new BitArray(number);
            //    Console.WriteLine("Same integer in binary numeral system: ");
            //    Console.WriteLine(myNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            BitArray someOtherNumber = new BitArray(1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1);
            
            Console.WriteLine(someOtherNumber[89]);
            Console.WriteLine(someOtherNumber);

            someOtherNumber[89] = 0;

            Console.WriteLine(someOtherNumber[89]);
            Console.WriteLine(someOtherNumber);
            
        }
    }
}
