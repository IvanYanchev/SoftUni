using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static int GetSequenceLenght(string[,] matrix, int row, int col, int changeRow, int changeCol)
        {
            int lenght = 1;
            while ((col + changeCol < matrix.GetLength(1)) &&
                    (col + changeCol >= 0) &&
                    (row + changeRow < matrix.GetLength(0)) &&
                    (matrix[row, col] == matrix[row + changeRow, col + changeCol]))
            {
                lenght++;
                row += changeRow;
                col += changeCol;
            }
            return lenght;
        }

        static void Main(string[] args)
        {
            string[,] matrix =
            {
                {"s", "qq", "s", "aa" },
                {"pp", "pp", "s", "bb" },
                {"pp", "pp", "s", "cc" },
                {"r", "pp", "pp", "dd" },
                {"az", "ti", "toi", "pp" },
            };
            int maxLenght = 1;
            int maxIndexRow = 0;
            int maxIndexCol = 0;
            int maxChangeIndexRow = 0;
            int maxChangeIndexCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (GetSequenceLenght(matrix, i, j, 0, 1) > maxLenght)
                    {
                        maxLenght = GetSequenceLenght(matrix, i, j, 0, 1);
                        maxIndexRow = i;
                        maxIndexCol = j;
                        maxChangeIndexRow = 0;
                        maxChangeIndexCol = 1;
                    }
                    if (GetSequenceLenght(matrix, i, j, 1, 1) > maxLenght)
                    {
                        maxLenght = GetSequenceLenght(matrix, i, j, 1, 1);
                        maxIndexRow = i;
                        maxIndexCol = j;
                        maxChangeIndexRow = 1;
                        maxChangeIndexCol = 1;
                    }
                    if (GetSequenceLenght(matrix, i, j, 1, 0) > maxLenght)
                    {
                        maxLenght = GetSequenceLenght(matrix, i, j, 1, 0);
                        maxIndexRow = i;
                        maxIndexCol = j;
                        maxChangeIndexRow = 1;
                        maxChangeIndexCol = 0;
                    }
                    if (GetSequenceLenght(matrix, i, j, 1, -1) > maxLenght)
                    {
                        maxLenght = GetSequenceLenght(matrix, i, j, 1, -1);
                        maxIndexRow = i;
                        maxIndexCol = j;
                        maxChangeIndexRow = 1;
                        maxChangeIndexCol = -1;
                    }
                }
            }

            for (int i = 0; i < maxLenght; i++)
            {
                Console.Write(matrix[maxIndexRow, maxIndexCol]);
                if (i < maxLenght - 1)
                {
                    Console.Write(", ");
                }
                maxIndexRow += maxChangeIndexRow;
                maxIndexCol += maxChangeIndexCol;
            }
        }
    }
}
