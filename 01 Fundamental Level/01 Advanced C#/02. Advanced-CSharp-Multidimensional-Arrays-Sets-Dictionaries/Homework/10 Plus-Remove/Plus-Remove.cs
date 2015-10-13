using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Remove
{
    class PlusRemove
    {
        static void Main(string[] args)
        {
            List<List<char>> boardOfChars = new List<List<char>>();
            int boardWidth = 0;
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString.ToUpper() == "END")
                {
                    break;
                }
                boardWidth = Math.Max(boardWidth, inputString.Length);
                boardOfChars.Add(inputString.ToLower().ToList());
            }

            int boardHeigth = boardOfChars.Count;
            int[,] boardMarkedForDel = new int[boardHeigth, boardWidth];

            for (int row = 1; row < boardHeigth - 1; row++)
            {
                for (int col = 1; col < boardWidth - 1; col++)
                {
                    if (col + 1 < boardOfChars[row].Count && col < boardOfChars[row - 1].Count && col < boardOfChars[row + 1].Count)  
                    {
                        if (boardOfChars[row][col] == boardOfChars[row][col + 1] &&
                            boardOfChars[row][col] == boardOfChars[row + 1][col] &&
                            boardOfChars[row][col] == boardOfChars[row][col - 1] &&
                            boardOfChars[row][col] == boardOfChars[row - 1][col])
                        {
                            boardMarkedForDel[row, col] = 1;
                            boardMarkedForDel[row, col + 1] = 1;
                            boardMarkedForDel[row + 1, col] = 1;
                            boardMarkedForDel[row, col - 1] = 1;
                            boardMarkedForDel[row - 1, col] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < boardHeigth; i++)
            {
                for (int j = boardWidth - 1; j >= 0; j--)
                {
                    if (boardMarkedForDel[i,j] == 1)
                    {
                        boardOfChars[i].RemoveAt(j);
                    }
                }
            }
            foreach (var list in boardOfChars)
            {
                Console.WriteLine(string.Join("", list));
            }
        }
    }
}
