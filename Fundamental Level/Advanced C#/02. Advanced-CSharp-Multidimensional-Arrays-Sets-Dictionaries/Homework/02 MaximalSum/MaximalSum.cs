using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int sqSize = 3;
            string inputSizeLine = Console.ReadLine();
            int[] matrixDim = inputSizeLine.Split(' ').Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixDim[0], matrixDim[1]];

            //int[,] matrix = { { 1, 5, 5, 2, 4 }, { 2, 1, 4, 14, 3 }, { 3, 7, 11, 2, 8 }, { 4, 8, 12, 16, 4 } };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputMatrixLine = Console.ReadLine();
                int[] matrixRow = inputMatrixLine.Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixRow[col];
                }
            }

            int sumMax = int.MinValue;
            int rowIndexMax = 0;
            int colIndexMax = 0;
            for (int row = 0; row <= matrix.GetLength(0) - sqSize; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - sqSize; col++)
                {
                    int sum = SumSquare(matrix, row, col, sqSize);
                    if (sum > sumMax)
                    {
                        sumMax = sum;
                        rowIndexMax = row;
                        colIndexMax = col;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", sumMax);
            PrintSquare(matrix, rowIndexMax, colIndexMax, sqSize);
        }

        static int SumSquare(int[,] matrix, int row, int col, int size)
        {
            int sum = 0;
            for (int i = row; i < row + size; i++)
            {
                for (int j = col; j < col + size; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        static void PrintSquare(int[,] matrix, int row, int col, int size)
        {
            for (int i = row; i < row + size; i++)
            {
                for (int j = col; j < col + size; j++)
                {
                    Console.Write("{0, 3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
