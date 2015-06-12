using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + i + 1; j++)
                {
                    Console.Write("{0,3}", j);
                }
                Console.WriteLine();
            }
        }
    }