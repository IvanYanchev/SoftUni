using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int num = 1;
        int i = 0;

        while (num <= n * n)
        {
            int indexRow = i;
            int indexCol = i;

            while (indexCol < n - i)
            {
                matrix[indexRow, indexCol] = num;
                indexCol++;
                num++;
            }
            indexCol--;
            indexRow++;
            while (indexRow < n - i)
            {
                matrix[indexRow, indexCol] = num;
                indexRow++;
                num++;
            }
            indexRow--;
            indexCol--;
            while (indexCol >= i)
            {
                matrix[indexRow, indexCol] = num;
                indexCol--;
                num++;
            }
            indexCol++;
            indexRow--;
            while (indexRow >= i + 1)
            {
                matrix[indexRow, indexCol] = num;
                indexRow--;
                num++;
            }
            i++;
        }

        for (int k = 0; k < n; k++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 4}", matrix[k, j]);
            }
            Console.WriteLine();
        }
    }
}