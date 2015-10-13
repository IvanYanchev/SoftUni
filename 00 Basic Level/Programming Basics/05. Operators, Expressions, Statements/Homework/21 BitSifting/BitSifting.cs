using System;

    class BitSifting
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            ulong sieve;
            ulong mask;
            for (int i = 1; i <= N; i++)
            {
                sieve = ulong.Parse(Console.ReadLine());
                n = n & ~sieve;
            }

            int bitCount = 0;
            for (int j = 0; j < 64; j++)
            {
                mask = (ulong)1 << j;
                ulong isThisBit1 = (n & mask) >> j;
                if (isThisBit1==1)
                {
                    bitCount++;
                }
            }

            Console.WriteLine(bitCount);
        }
    }