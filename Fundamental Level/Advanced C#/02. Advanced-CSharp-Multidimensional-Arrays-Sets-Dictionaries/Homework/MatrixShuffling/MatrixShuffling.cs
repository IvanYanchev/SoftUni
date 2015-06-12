using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffling
{
    class MatrixShuffling
    {

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}  ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfCols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[numberOfRows, numberOfCols];

            // string[,] matrix = { { "1", "2", "3" }, { "4", "5", "6" } };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "END")
                {
                    break;
                }
                string[] commands = commandLine.Split(' ').ToArray();
                if (commands[0] == "swap" && commands.Length == 5 )
                {
                    int x1 = int.Parse(commands[1]);
                    int y1 = int.Parse(commands[2]);
                    int x2 = int.Parse(commands[3]);
                    int y2 = int.Parse(commands[4]);
                    if (x1 > numberOfRows - 1 |
                        y1 > numberOfCols - 1 |
                        x2 > numberOfRows - 1 |
                        y2 > numberOfCols - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;
                        PrintMatrix(matrix);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            } 
        }
    }
}
