using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffle
{
    class MatrixShuffle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            string inputText = Console.ReadLine();

            int num = 1;
            int i = 0;

            while (num <= n * n)
            {
                int indexRow = i;
                int indexCol = i;

                while (indexCol < n - i)
                {
                    FillCell(matrix, indexRow, indexCol, num, inputText);
                    indexCol++;
                    num++;
                }
                indexCol--;
                indexRow++;
                while (indexRow < n - i)
                {
                    FillCell(matrix, indexRow, indexCol, num, inputText);
                    indexRow++;
                    num++;
                }
                indexRow--;
                indexCol--;
                while (indexCol >= i)
                {
                    FillCell(matrix, indexRow, indexCol, num, inputText);
                    indexCol--;
                    num++;
                }
                indexCol++;
                indexRow--;
                while (indexRow >= i + 1)
                {
                    FillCell(matrix, indexRow, indexCol, num, inputText);
                    indexRow--;
                    num++;
                }
                i++;
            }

            string sentence = ExtractChessboardPatternLetters(matrix, 0, 0) + ExtractChessboardPatternLetters(matrix, 0, 1);

            string leftToRight = string.Join("", sentence.Where(x => Char.IsLetter(x)).ToArray());
            string rightToLeft = string.Join("", leftToRight.Reverse());
            string color = "#E0000F";
            if (leftToRight.Equals(rightToLeft, StringComparison.OrdinalIgnoreCase))
            {
                color = "#4FE000";
            }

            Console.WriteLine("<div style='background-color:{0}'>{1}</div>", color, sentence);
        }


        static void FillCell(char[,] matrix, int row, int col, int num, string text)
        {
            char ch = num <= text.Length ? text[num - 1] : ' ';
            matrix[row, col] = ch;
        }


        static string ExtractChessboardPatternLetters(char[,] matrix, int i, int j)
        {
            string subSentence = string.Empty;
            for (int row = i; row < matrix.GetLength(0); row++)
            {
                for (int col = (row + j) % 2; col < matrix.GetLength(1); col += 2)
                {
                    subSentence += matrix[row, col];
                }
            }
            return subSentence;
        }
    }
}
