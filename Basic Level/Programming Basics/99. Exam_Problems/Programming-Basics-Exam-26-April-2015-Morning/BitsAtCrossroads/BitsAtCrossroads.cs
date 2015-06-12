using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAtCrossroads
{
    class BitsAtCrossroads
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            uint[] board = new uint[n];

            int crossroadsCount = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("end", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                int crossroadRow = int.Parse(input.Split(' ')[0]);
                int crossroadCol = int.Parse(input.Split(' ')[1]);
                crossroadsCount++;
                int indexRow = crossroadRow;
                int indexCol = crossroadCol;
                board[indexRow] = board[indexRow] | (1u << indexCol);

                while (indexRow > 0 && indexCol > 0)
                {
                    indexRow--;
                    indexCol--;
                    if ((board[indexRow] & (1u << indexCol)) >> indexCol == 1)
                    {
                        crossroadsCount++;
                    }
                    else
                    {
                        board[indexRow] = board[indexRow] | (1u << indexCol);
                    }
                }
                indexRow = crossroadRow;
                indexCol = crossroadCol;
                while (indexRow > 0 && indexCol < n - 1)
                {
                    indexRow--;
                    indexCol++;
                    if ((board[indexRow] & (1u << indexCol)) >> indexCol == 1)
                    {
                        crossroadsCount++;
                    }
                    else
                    {
                        board[indexRow] = board[indexRow] | (1u << indexCol);
                    }
                }
                indexRow = crossroadRow;
                indexCol = crossroadCol;
                while (indexRow < n - 1 && indexCol < n - 1)
                {
                    indexRow++;
                    indexCol++;
                    if ((board[indexRow] & (1u << indexCol)) >> indexCol == 1)
                    {
                        crossroadsCount++;
                    }
                    else
                    {
                        board[indexRow] = board[indexRow] | (1u << indexCol);
                    }
                }
                indexRow = crossroadRow;
                indexCol = crossroadCol;
                while (indexRow < n - 1 && indexCol > 0)
                {
                    indexRow++;
                    indexCol--;
                    if ((board[indexRow] & (1u << indexCol)) >> indexCol == 1)
                    {
                        crossroadsCount++;
                    }
                    else
                    {
                        board[indexRow] = board[indexRow] | (1u << indexCol);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(board[i]);
            }
            Console.WriteLine(crossroadsCount);
        }
    }
}
