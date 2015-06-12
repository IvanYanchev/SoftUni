using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(List<List<char>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string rotationInput = Console.ReadLine();
            int rotation = int.Parse(rotationInput.Split(new char[] { '(', ')' })[1]);

            List<List<char>> matrix = new List<List<char>>();
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString.ToUpper() == "END")
                {
                    break;
                }
                matrix.Add(inputString.ToList());
            }

            int matrixWidth = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                matrixWidth = Math.Max(matrixWidth, matrix[i].Count);
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                int numberOfEndingSpaces = matrixWidth - matrix[i].Count;
                for (int j = 0; j < numberOfEndingSpaces; j++)
                {
                    matrix[i].Add(' ');
                }
            }
            
            switch (rotation % 360)
            {
                case 0:
                    PrintMatrix(matrix);
                    break;
                case 90:
                    char[,] rotated90 = new char[matrixWidth, matrix.Count];
                    for (int row = 0; row < matrixWidth; row++)
                    {
                        for (int col = 0; col < matrix.Count; col++)
                        {
                            rotated90[row, col] = matrix[(matrix.Count - 1) - col][row];
                        }
                    }
                    PrintMatrix(rotated90);
                    break;
                case 180:
                    char[,] rotated180 = new char[matrix.Count, matrixWidth];
                    for (int row = 0; row < matrix.Count; row++)
                    {
                        for (int col = 0; col < matrixWidth; col++)
                        {
                            rotated180[row, col] = matrix[(matrix.Count - 1) - row][(matrixWidth - 1) - col];
                        }
                    }
                    PrintMatrix(rotated180);
                    break;
                case 270:
                    char[,] rotated270 = new char[matrixWidth, matrix.Count];
                    for (int row = 0; row < matrixWidth; row++)
                    {
                        for (int col = 0; col < matrix.Count; col++)
                        {
                            rotated270[row, col] = matrix[col][(matrixWidth - 1) - row];
                        }
                    }
                    PrintMatrix(rotated270);
                    break;
            }
        }
    }
}