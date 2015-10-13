using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleLoops
{
    class SimpleLoops
    {
        static void Main(string[] args)
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            BigInteger tNext = 0;

            if (n==1)
            {
                Console.WriteLine(t1);
            }
            else if (n==2)
            {
                Console.WriteLine(t2);
            }
            else if (n==3)
            {
                Console.WriteLine(t3);
            }
            else
            {
                
                for (int i = 3; i < n; i++)
                {
                    tNext = t1 + t2 + t3;
                    t1 = t2;
                    t2 = t3;
                    t3 = tNext;
                }
                Console.WriteLine(tNext);
            }
        }
    }
}
