using System;

    class BubbleSort
    {
        static void Main()
        {
            int[] array = { 3, 5, 7, 8, 12, -3, -23, 156, 76, 2, 9, -30, -40, -50, 1234, 7 };
            array = BubbleSortMethod(array);
            foreach (var num in array)
            {
                Console.Write("{0} ", num);
            }
        }

        static int[] BubbleSortMethod(int[] matrix)
        {
            for (int i = matrix.Length; i >= 1; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    if (matrix[j] > matrix[j+1])
                    {
                        int temp = matrix[j + 1];
                        matrix[j + 1] = matrix[j];
                        matrix[j] = temp;
                    }
                }
            }
            return matrix;
        }
    }