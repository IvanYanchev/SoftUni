using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGravity
{
    class TextGravity
    {
        static void Main(string[] args)
        {
            int matrixWidth = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            
            int matrixHeigth = inputText.Length % matrixWidth == 0 ? (inputText.Length / matrixWidth) : (1 + inputText.Length / matrixWidth);
            char[,] matrix = new char[matrixHeigth, matrixWidth];

            for (int row = 0; row < matrixHeigth; row++)
            {
                for (int col = 0; col < matrixWidth; col++)
                {
                    try
                    {
                        matrix[row, col] = inputText[row * matrixWidth + col];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            for (int row = matrixHeigth - 1; row >= 1; row--)
            {
                for (int col = 0; col < matrixWidth; col++)
                {
                    if (matrix[row, col] == ' ')
                    {
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (matrix[i,col] != ' ')
                            {
                                matrix[row, col] = matrix[i, col];
                                matrix[i, col] = ' ';
                                break;
                            }
                        }
                    }
                    
                }
            }
            Console.Write(@"<table>");
            for (int row = 0; row < matrixHeigth; row++)
            {
                Console.Write(@"<tr>");
                for (int col = 0; col < matrixWidth; col++)
                {
                    Console.Write(@"<td>{0}</td>", matrix[row, col]);
                }
                Console.Write(@"</tr>");
            }
            Console.Write(@"</table>");
        }
    }
}
