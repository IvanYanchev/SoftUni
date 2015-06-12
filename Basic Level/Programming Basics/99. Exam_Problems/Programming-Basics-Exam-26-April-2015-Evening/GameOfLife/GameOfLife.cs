using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameOfLife
    {
        static void Main(string[] args)
        {
            int[,] initialBoard = new int[12, 12];
            int[,] resultingBoard = new int[12, 12];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                initialBoard[x + 1, y + 1] = 1;
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= 1; j--)
                {
                    int ur = initialBoard[i - 1, j + 1];
                    int uu = initialBoard[i - 1, j];
                    int ul = initialBoard[i - 1, j - 1];
                    int ll = initialBoard[i, j - 1];
                    int dl = initialBoard[i + 1, j - 1];
                    int dd = initialBoard[i + 1, j];
                    int dr = initialBoard[i + 1, j + 1];
                    int rr = initialBoard[i, j + 1];
                    int sum = ur + uu + ul + ll + dl + dd + dr + rr;

                 /* if (initialBoard[i, j] == 1 && (sum < 2 || sum > 3))
                    {
                        resultingBoard[i, j] = 0;
                    }  */
                    if (initialBoard[i,j] == 1 && sum >= 2 && sum <= 3)
                    {
                        resultingBoard[i, j] = 1;
                    }
                    if (initialBoard[i,j] == 0 && sum == 3)
                    {
                        resultingBoard[i, j] = 1;
                    }

                    Console.Write(resultingBoard[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
