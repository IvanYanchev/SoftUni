using System;


//Problem 6.	Calculate N! / K!

namespace CalculateFactDiv
{
    class CalculateFactDiv
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int resultProblem6 = 1;
            for (int j = k + 1; j <= n; j++)
            {
                resultProblem6 *= j;
            }
            Console.WriteLine(resultProblem6);
        }
    }
}
