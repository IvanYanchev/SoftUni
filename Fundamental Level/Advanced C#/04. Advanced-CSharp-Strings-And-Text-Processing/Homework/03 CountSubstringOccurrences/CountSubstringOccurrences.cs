using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();

            string substring = Console.ReadLine().ToLower();

            int countFound = 0;
            int index = 0;

            while (true)
            {
                index = inputString.IndexOf(substring, index);
                if (index >= 0)
                {
                    countFound++;
                    index++;
                }
                else
                {
                    break; 
                }
            }

            Console.WriteLine(countFound);
        }
    }
}
