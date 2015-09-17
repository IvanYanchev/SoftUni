using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main(string[] args)
        {
            int inputStringMaxLenght = 0;
            string[] inputString = new string[4];
            for (int i = 0; i < 4; i++)
			{
			    inputString[i] = Console.ReadLine();
                inputStringMaxLenght = Math.Max(inputStringMaxLenght, inputString[i].Length);
			}

            char[,] matrix = new char[4, inputStringMaxLenght];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < inputString[i].Length; j++)
                {
                    matrix[i,j] = inputString[i].ElementAt(j);
                }
            }

            int coinsCollect = 0;
            if (matrix[0,0] == '$')
            {
                coinsCollect = 1;
            }
            int wallsHit = 0;
            int row = 0;
            int col = 0;

            string commandsLine = Console.ReadLine();

            for (int i = 0; i < commandsLine.Length; i++)
            {
                switch (commandsLine.ElementAt(i))
                {
                    case '>':
                        if (IsLegalMovement(matrix, row, col, 1, 0, 0, 0)) // Right
                        {
                            col++;
                        }
                        else
                        {
                            wallsHit++;   
                        }
                        break;
                    case 'v':
                        if (IsLegalMovement(matrix, row, col, 0, 1, 0, 0)) // Down
                        {
                            row++;
                        }
                        else
                        {
                            wallsHit++;   
                        }
                        break;
                    case '<':
                        if (IsLegalMovement(matrix, row, col, 0, 0, -1, 0)) // Left
                        {
                            col--;
                        }
                        else
                        {
                            wallsHit++;   
                        }
                        break;
                    case '^':
                        if (IsLegalMovement(matrix, row, col, 0, 0, 0, -1)) // Up
                        {
                            row--;
                        }
                        else
                        {
                            wallsHit++;   
                        }
                        break;
                }
                if (matrix[row,col] == '$')
                {
                    coinsCollect++;
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsCollect);
            Console.WriteLine("Walls hit: {0}", wallsHit);
        }

        static bool IsLegalMovement(char[,] matrix, int row, int col, int stepRight, int stepDown, int stepLeft, int stepUp)
        {
            bool isLegal = false;
            if (row + stepDown < matrix.GetLength(0) && row + stepUp >= 0 && col + stepRight < matrix.GetLength(1) && col + stepLeft >= 0)
            {
                isLegal = true;
            }
            return isLegal;
        }
    }
}
