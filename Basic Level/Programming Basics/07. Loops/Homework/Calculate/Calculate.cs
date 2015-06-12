using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            // Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

            int n = 5;
            int x = -4;
            double sumProblem5 = 1;
            double member = 1;
            for (int i = 1; i <= n; i++)
            {
                member = member * i / x;
                sumProblem5 = sumProblem5 + member;
            }
            Console.WriteLine("{0:F5}", sumProblem5);

            //Problem 6.	Calculate N! / K!

            n = 8;
            int k = 3;
            int resultProblem6 = 1;
            for (int j = k+1; j <= n; j++)
            {
                resultProblem6 *= j;
            }
            Console.WriteLine(resultProblem6);

            // Problem 7.	Calculate N! / (K! * (N-K)!)

            n = 10;
            k = 6;
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
