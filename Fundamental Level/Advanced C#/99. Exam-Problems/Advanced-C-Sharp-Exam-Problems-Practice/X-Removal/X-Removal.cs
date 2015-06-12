using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Removal
{
    class XRemoval
    {
        static void Main(string[] args)
        {
            List<List<char>> matrix = new List<List<char>>();

            // Reading the matrix from the console
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine.Equals("END", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    matrix.Add(inputLine.ToList());    
                } 
            }

            // Initialize the ancillary matrix
            int[][] matrixOfIndexesMarkedForDel = new int[matrix.Count][];
            for (int i = 0; i < matrix.Count; i++)
            {
                matrixOfIndexesMarkedForDel[i] = new int[matrix[i].Count];
            }

            // Check for X shape
            for (int row = 1; row < matrix.Count - 1; row++)
            {
                for (int col = 1; col < matrix[row].Count; col++)
                {
                    if (IsXShape(matrix, row, col))
                    {
                        MarkXShapeForDel(matrixOfIndexesMarkedForDel, row, col);
                    }
                }
            }

            // Print the result
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    if (matrixOfIndexesMarkedForDel[row][col] != 1)
                    {
                        Console.Write(matrix[row][col]);
                    }
                }
                Console.WriteLine();
            }
        }

        static bool IsXShape(List<List<char>> matrix, int row, int col)
        {
            try
            {
                if (char.ToLower(matrix[row - 1][col - 1]).Equals(char.ToLower(matrix[row][col])) &&
                            char.ToLower(matrix[row - 1][col + 1]).Equals(char.ToLower(matrix[row][col])) &&
                            char.ToLower(matrix[row + 1][col - 1]).Equals(char.ToLower(matrix[row][col])) &&
                            char.ToLower(matrix[row + 1][col + 1]).Equals(char.ToLower(matrix[row][col])))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        static void MarkXShapeForDel(int[][] jaggedArr, int row, int col)
        {
            jaggedArr[row - 1][col - 1] = 1;
            jaggedArr[row - 1][col + 1] = 1;
            jaggedArr[row][col] = 1;
            jaggedArr[row + 1][col - 1] = 1;
            jaggedArr[row + 1][col + 1] = 1;
        }
    }
}
