using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixDimensions[0], matrixDimensions[1]];

            string snakeString = Console.ReadLine();
            int indexColChange = -1;
            int col = matrix.GetLength(1) - 1;
            int indexCh = 0;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                while (col >= 0 && col < matrix.GetLength(1))
                {
                    indexCh = indexCh < snakeString.Length ? indexCh : 0;
                    char ch = snakeString[indexCh];
                    matrix[row, col] = ch;
                    indexCh++;
                    col += indexColChange;
                }
                indexColChange = -indexColChange;

                if (col < 0)
                {
                    col = 0;
                }
                if (col >= matrix.GetLength(1))
                {
                    col = matrix.GetLength(1) - 1;
                }
            }

            int[] shotParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int impactRow = shotParameters[0];
            int impactCol = shotParameters[1];
            int impactRadius = shotParameters[2];

            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    double distanceToImpactCenter = Math.Sqrt(Math.Pow((impactRow - y), 2) + Math.Pow((impactCol - x), 2));
                    if (distanceToImpactCenter <= impactRadius)
                    {
                        matrix[y, x] = ' ';
                    }
                }
            }

            for (int row = matrix.GetLength(0) - 1; row >= 1; row--)
            {
                for (int coll = 0; coll < matrix.GetLength(1); coll++)
                {
                    if (matrix[row, coll] == ' ')
                    {
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (matrix[i, coll] != ' ')
                            {
                                matrix[row, coll] = matrix[i, coll];
                                matrix[i, coll] = ' ';
                                break;
                            }
                        }
                    }

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
