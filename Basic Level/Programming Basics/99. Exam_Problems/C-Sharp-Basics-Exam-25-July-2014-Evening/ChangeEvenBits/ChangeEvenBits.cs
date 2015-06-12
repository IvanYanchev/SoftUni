using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeEvenBits
{
    class ChangeEvenBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int index = 0; index < n; index++)
            {
                num[index] = int.Parse(Console.ReadLine());
            }
            ulong l = ulong.Parse(Console.ReadLine());
            int bitsChangedCount = 0;

            for (int index = 0; index < n; index++)
            {
                string numAsBinary = Convert.ToString(num[index], 2);
                int evenPositions = numAsBinary.Length;
                for (int position = 0; position < 2 * evenPositions; position += 2)
                {
                    ulong bitAtPosition = (l & 1ul << position) >> position;
                    if (bitAtPosition == 0)
                    {
                        l = l | 1ul << position;
                        bitsChangedCount++;
                    }

                }
            }
            Console.WriteLine(l);
            Console.WriteLine(bitsChangedCount);
        }
    }
}
