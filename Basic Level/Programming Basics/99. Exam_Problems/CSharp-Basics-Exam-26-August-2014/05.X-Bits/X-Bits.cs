using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.X_Bits
{
    class XBits
    {
        static void Main(string[] args)
        {
            int[] bitsBoard = new int[8];
            for (int row = 0; row < 8; row++)
            {
                bitsBoard[row] = int.Parse(Console.ReadLine());
            }

            int countXBits = 0;

            for (int row = 1; row <= 6; row++)
            {
                for (int col = 1; col <= 30; col++)
                {
                    if (IsFoundXBit(bitsBoard, row, col))
                    {
                        countXBits++;
                    }
                }
            }

            Console.WriteLine(countXBits);
        }

        static bool IsFoundXBit(int[] bitsBoard, int row, int col)
        {
            bool isFound = false;
            if (((bitsBoard[row - 1] >> (30 - col)) & 7) == 5 &&
                ((bitsBoard[row] >> (30 - col)) & 7) == 2 &&
                ((bitsBoard[row + 1] >> (30 - col)) & 7) == 5) 
            {
                isFound = true;
            }
            return isFound;
        }
    }
}
