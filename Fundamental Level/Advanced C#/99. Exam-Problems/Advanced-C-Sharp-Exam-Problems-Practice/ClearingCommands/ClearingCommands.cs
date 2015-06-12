using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClearingCommands
{
    class ClearingCommands
    {
        static void ClearGarbage(List<char[]> matrix, int row, int col, int changeRow, int changeCol)
        {
            while (true)
            {
                row += changeRow;
                col += changeCol;
                if (row < 0 || row >= matrix.Count || 
                    col < 0 || col >= matrix[row].Length || 
                    matrix[row][col] == '>' ||
                    matrix[row][col] == 'v' ||
                    matrix[row][col] == '<' || 
                    matrix[row][col] == '^')
                {
                    break;
                }
                else
                {
                    matrix[row][col] = ' ';
                }
            }
            return;
        }


        static void Main(string[] args)
        {
            List<char[]> matrix = new List<char[]>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine.StartsWith("END", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    matrix.Add(inputLine.ToCharArray());
                }
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    switch (matrix[i][j])
                    {
                        case '>':
                            {
                                ClearGarbage(matrix, i, j, 0, 1);
                                break;
                            }
                        case 'v':
                            {
                                ClearGarbage(matrix, i, j, 1, 0);
                                break;
                            }
                        case '<':
                            {
                                ClearGarbage(matrix, i, j, 0, -1);
                                break;
                            }
                        case '^':
                            {
                                ClearGarbage(matrix, i, j, -1, 0);
                                break;
                            }
                    }
                }
            }

            for (int i = 0; i < matrix.Count; i++)
			{
                string outputLine = string.Join("", matrix[i]);
                outputLine = SecurityElement.Escape(outputLine);
                Console.WriteLine("{0}{1}{2}", "<p>", outputLine, "</p>");
			}
            
        }
    }
}
