using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Bunker_Buster
{
    class BunkerBuster
    {
        static void Main(string[] args)
        {
            string matrixDimentionsInput = Console.ReadLine();
            int[] matrixDimentions = matrixDimentionsInput.Split(' ').Select(int.Parse).ToArray();

            int n = matrixDimentions[0]; // number of rows
            int m = matrixDimentions[1]; // number of cols

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++) 
            {
                string rowInput = Console.ReadLine();
                string[] rowElements = rowInput.Split(' ');

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(rowElements[col]);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "cease fire!")
                {
                    break;
                }
                else
                {
                    string[] commandArguments = command.Split(' ');

                    int bombRow = int.Parse(commandArguments[0]);
                    int bombCol = int.Parse(commandArguments[1]);
                    int bombPower = commandArguments[2][0];

                    int halfBombPower = (int)Math.Ceiling((double)bombPower / 2);

                    for (int row = bombRow - 1; row <= bombRow + 1; row++)
                    {
                        for (int col = bombCol - 1; col <= bombCol + 1; col++)
                        {
                            if (row >=0 && row < n && col >= 0 && col < m && !(row == bombRow && col == bombCol))
                            {
                                matrix[row, col] -= halfBombPower;
                            }
                        }
                    }

                    matrix[bombRow, bombCol] -= bombPower;
                }
            }

            int countCellsDestroyed = 0;

            foreach (var cell in matrix)
            {
                if (cell <= 0) 
                {
                    countCellsDestroyed++;
                }
            }

            double totalDestructionInPercent = (100 * (double)countCellsDestroyed) / (m * n);

            Console.WriteLine("Destroyed bunkers: {0}", countCellsDestroyed);
            Console.WriteLine("Damage done: {0:F1} %", totalDestructionInPercent);
        }
    }
}
