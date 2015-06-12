using System;


// Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN


namespace CalculateFactSum
{
    class CalculateFactSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double sumProblem5 = 1;
            double member = 1;
            for (int i = 1; i <= n; i++)
            {
                member = member * i / x;
                sumProblem5 += member;
            }
            Console.WriteLine("{0:F5}", sumProblem5);
        }
    }
}
