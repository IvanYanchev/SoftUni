using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetarsGame
{
    class PetarsGame
    {
        static void Main(string[] args)
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replaceString = Console.ReadLine();
            ulong sum = 0;

            for (ulong i = startNumber; i < endNumber; i++)
            {
                if (i % 5 ==0)
                {
                    sum = sum + i;
                }
                else
                {
                    sum = sum + (i % 5);
                }
            }
            string sumAsString = sum.ToString();
            
            if (sum % 2 == 0)
            {
                string firstLetter = Convert.ToString(sumAsString.ElementAt(0));
                sumAsString = sumAsString.Replace(firstLetter, replaceString);
                Console.WriteLine(sumAsString);
            }
            else
            {
                string lastLetter = Convert.ToString(sumAsString.ElementAt(sumAsString.Length - 1));
                sumAsString = sumAsString.Replace(lastLetter, replaceString);
                Console.WriteLine(sumAsString);
            }
        }
    }
}
