using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Knight_Path
{
    class KnightPath
    {
        static void Main(string[] args)
        {
            int size = 8;
            int[,] chessBoard = new int[size, size];

            int positionCol = size - 1;
            int positionRow = 0;
            Invert(chessBoard, positionRow, positionCol);

            while (true)
            {
                string move = Console.ReadLine();

                if (move == "stop")
                {
                    break;
                }
                else
                {
                    switch (move)
                    {
                        case "left up":
                            {
                                if ((positionCol - 2) >= 0 && (positionRow - 1 >= 0))
                                {
                                    positionCol -= 2;
                                    positionRow -= 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "left down":
                            {
                                if ((positionCol - 2) >= 0 && (positionRow + 1 < size))
                                {
                                    positionCol -= 2;
                                    positionRow += 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "right up":
                            {
                                if ((positionCol + 2) < size && (positionRow - 1 >= 0))
                                {
                                    positionCol += 2;
                                    positionRow -= 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "right down":
                            {
                                if ((positionCol + 2) < size && (positionRow + 1 < size))
                                {
                                    positionCol += 2;
                                    positionRow += 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "up left":
                            {
                                if ((positionRow - 2) >= 0 && (positionCol - 1 >= 0))
                                {
                                    positionRow -= 2;
                                    positionCol -= 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "up right":
                            {
                                if ((positionRow - 2) >= 0 && (positionCol + 1 < size))
                                {
                                    positionRow -= 2;
                                    positionCol += 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "down left":
                            {
                                if ((positionRow + 2) < size && (positionCol - 1 >= 0))
                                {
                                    positionRow += 2;
                                    positionCol -= 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                        case "down right":
                            {
                                if ((positionRow + 2) < size && (positionCol + 1 < size))
                                {
                                    positionRow += 2;
                                    positionCol += 1;
                                    Invert(chessBoard, positionRow, positionCol);
                                }
                                break;
                            }
                    }
                }
            }

            for (int row = 0; row < size; row++)
            {
                string line = string.Empty;
                for (int col = 0; col < size; col++)
			    {
                    line += chessBoard[row, col];
			    }
                int output = Convert.ToInt32(line, 2);
                if (output != 0)
                {
                    Console.WriteLine(output);
                }
            }
        }

        static void Invert(int[,] chessBoard, int positionRow, int positionCol)
        {
            if (chessBoard[positionRow, positionCol] == 0)
            {
                chessBoard[positionRow, positionCol] = 1;
            }
            else
            {
                chessBoard[positionRow, positionCol] = 0;
            }
        }
    }
}
