using System;

    class NthDigit
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int a = (int)Math.Pow(10, n - 1);
            int b = num / a;
            int result = b % 10;
            Console.WriteLine(result);
        }
    }
