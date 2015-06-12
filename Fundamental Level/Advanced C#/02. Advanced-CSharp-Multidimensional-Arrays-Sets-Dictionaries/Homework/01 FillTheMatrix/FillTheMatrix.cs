using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void FillingMatrixPatternA(int[,] arr)
        {
            int element = 1;
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    arr[row, col] = element;
                    element++;
                }
            }
        }

        static void FillingMatrixPatternB(int[,] arr)
        {
            int element = 1;
            int row = 0;
            int rowIndexChange = 1;
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                do
                {
                    arr[row, col] = element;
                    element++;
                    row += rowIndexChange;
                } while (row >= 0 && row < arr.GetLength(0));

                row -= rowIndexChange;
                rowIndexChange = -rowIndexChange;
            }
        }

        static void PrintMatrix(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write("{0,3}", arr[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = 8;
            int[,] matrix = new int[n, n];

            Console.WriteLine("Pattern A:");
            FillingMatrixPatternA(matrix);
            PrintMatrix(matrix);

            Console.WriteLine();

            Console.WriteLine("Pattern B:");
            FillingMatrixPatternB(matrix);
            PrintMatrix(matrix);
        }
    }
}
