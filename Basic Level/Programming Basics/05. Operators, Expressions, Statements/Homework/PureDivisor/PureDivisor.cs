using System;

    class PureDivisor
    {
        static void Main()
        {
            for (int i = 1; i <= 6; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool isDevidedBy9 = (n % 9) == 0;
                bool isDevidedBy11 = (n % 11) == 0;
                bool isDevidedBy13 = (n % 13) == 0;
                Console.WriteLine(isDevidedBy9 || isDevidedBy11 || isDevidedBy13);
            }
        }
    }
