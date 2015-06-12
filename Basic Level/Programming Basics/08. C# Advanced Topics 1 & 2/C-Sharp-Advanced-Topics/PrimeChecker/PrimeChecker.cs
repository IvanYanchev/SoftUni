using System;

    class PrimeChecker
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine(isPrime(n));
            }
        }

        static bool isPrime(long num)
        {
            bool isFoundDevisor = false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isFoundDevisor = true;
                    break;
                }
            }
            return !isFoundDevisor;
        }
    }