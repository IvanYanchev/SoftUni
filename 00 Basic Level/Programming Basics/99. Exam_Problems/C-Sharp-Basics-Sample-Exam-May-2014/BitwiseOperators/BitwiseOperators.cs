using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    class BitwiseOperators
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                int pInverted = 0;
                int pReversed = 0;
                int position = 0;
                bool isFirstBitOtherThanZero = false;
                for (int j = 31; j >= 0; j--)
                {
                    int bitAtPosition = (p & (1 << j)) >> j;
                    if (bitAtPosition == 1)
                    {
                        isFirstBitOtherThanZero = true;
                    }
                    if (isFirstBitOtherThanZero)
                    {
                        switch (bitAtPosition)
                        {
                            case 0:
                                pInverted = pInverted | (1 << j);
                                position++;
                                break;
                            case 1:
                                pInverted = pInverted & ~(1 << j);
                                pReversed = pReversed | (1 << position);
                                position++;
                                break;
                        }
                    }
                }
                int pResult = (p ^ pInverted) & pReversed;
                Console.WriteLine(pResult);
            }
        }
    }
}
