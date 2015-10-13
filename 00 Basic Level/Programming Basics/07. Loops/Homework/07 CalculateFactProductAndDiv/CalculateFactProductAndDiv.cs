using System;


// Problem 7.	Calculate N! / (K! * (N-K)!)

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 1;
            for (long i = n - k + 1; i <= n; i++)
            {
                a *= i;
            }
            for (long j = 1; j <= k; j++)
            {
                b *= j;
            }
            double resultProblem7 = a / b;
            Console.WriteLine(resultProblem7);
        }
    }
}
