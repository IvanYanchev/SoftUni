using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        string[,] matrix = new string[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                string newstring = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                matrix[i, j] = newstring;
                Console.Write("{0}  ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}