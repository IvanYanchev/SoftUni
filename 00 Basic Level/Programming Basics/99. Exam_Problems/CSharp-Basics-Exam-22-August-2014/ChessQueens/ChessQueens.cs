using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueens
{
    class ChessQueens
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            string[,] chessBoard = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = string.Format("{0}{1}", (char)('a' + row), col + 1);
                }
            }

            bool isNotFoundValidPosition = true;

            foreach (var queen1 in chessBoard)
            {
                foreach (var queen2 in chessBoard)
                {
                    int distRow = Math.Abs(queen1[0] - queen2[0]);
                    int distCol = Math.Abs(int.Parse(queen1.Substring(1)) - int.Parse(queen2.Substring(1)));
                    if ((distRow - 1 == d && distCol == 0) ||
                        (distRow == 0 && distCol - 1 == d) ||
                        (distRow - 1 == d && distCol - 1 == d))
                    {
                        Console.WriteLine("{0} - {1}", queen1, queen2);
                        isNotFoundValidPosition = false;
                    }
                }
            }

            if (isNotFoundValidPosition)
            {
                Console.WriteLine("No valid positions");
            }
        }
    }
}
