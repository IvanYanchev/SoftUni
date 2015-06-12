using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                for (int j = 1; j <= 2 * n; j++)
                {
                    Console.Write('*');
                }
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= 2 * n; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            else
            {
                if (i != (int)((n - 1) / 2 + 1))
                {
                    Console.Write('*');
                    for (int j = 2; j <= (2 * n) - 1; j++)
                    {
                        Console.Write('/');
                    }
                    Console.Write('*');
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                    for (int j = 2; j <= (2 * n) - 1; j++)
                    {
                        Console.Write('/');
                    }
                    Console.Write('*');
                    Console.WriteLine();
                }
                else
                {
                    Console.Write('*');
                    for (int j = 2; j <= (2 * n) - 1; j++)
                    {
                        Console.Write('/');
                    }
                    Console.Write('*');
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write('|');
                    }
                    Console.Write('*');
                    for (int j = 2; j <= (2 * n) - 1; j++)
                    {
                        Console.Write('/');
                    }
                    Console.Write('*');
                    Console.WriteLine();
                }
            }
        }
    }
}
