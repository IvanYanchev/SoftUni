using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string inputString = Console.ReadLine();

            string outputString = string.Empty;

            if (inputString.Length > 20)
            {
                outputString = inputString.Substring(0, 20);
            }
            else
            {
                outputString = inputString.PadRight(20, '*');
            }

            Console.WriteLine(outputString);
        }
    }
}
