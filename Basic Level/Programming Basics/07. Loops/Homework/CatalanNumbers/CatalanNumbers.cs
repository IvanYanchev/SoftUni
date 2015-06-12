using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            int n = 5;
            BigInteger a = 1;
            BigInteger b = 1;
 
            for (int i = n + 2; i <= 2 * n; i++)
            {
                a = a * i;
            }
            for (int j = 1; j <= n; j++)
            {
                b = b * j;
            }

            double result = (double)(a / b);
            Console.WriteLine(result);
        }
    }