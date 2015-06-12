using System;

    class BigAndOdd
    {
        static void Main()
        {
            for (int i=1; i<=5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool isGreater = n > 20;
                bool isOdd = (n % 2) == 1;
                Console.WriteLine(" -> " + (isGreater && isOdd));
            }
        }
    }
