using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0: Console.WriteLine(1); break;
                case 1: Console.WriteLine(1); break;
                default: Console.WriteLine(fib(n)); break;
            }
        }

        static int fib(int n)
        {
            int[] array = new int[n+1];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }
    }