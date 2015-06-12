using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            foreach (var number in FindPrimesInRange(a,b))
            {
                Console.Write("{0} ", number);
            }

        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if (startNum <= 1) startNum = 2;
            for (int num = startNum; num <= endNum; num++)
            {
                bool isFoundPrime = true;
                for (int div = 2; div <= Math.Sqrt(num); div++)
                {
                    if (num % div == 0)
                    {
                        isFoundPrime = false;
                        break;
                    }
                }
                if (isFoundPrime) primes.Add(num);
            }
            return primes;
        }
    }
}
