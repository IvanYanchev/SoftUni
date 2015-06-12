using System;

class BitsExchange
{
    static void Main()
    {
        uint n = 2369124121; // number n
        int p = 24; // start position second bit sequence
        int q = 3; // start position first bit sequence
        int k = 3; // length of bit sequence

        uint[] bits = new uint[32];

        if (p < 0 || q < 0 || k < 0 || (p + k - 1) > 31 || (q + k - 1) > 31) //checking if some of the parameters are out of range
        {
            Console.WriteLine("out of range");
        }
        else
        {
            if (Math.Abs(p - q) >= (k - 1)) //checking if the two sequences are overlaping
            {
                for (int i = 0; i <= 31; i++)
                {
                    uint nShiftedRight = n >> i;
                    uint mask = 1;
                    bits[i] = nShiftedRight & mask;
                    Console.Write(bits[i]);
                }

                Console.WriteLine(); // insert new line

                for (int j = p; j <= (p + k - 1); j++)
                {
                    if (bits[j + (q - p)] == 0)
                    {
                        uint mask = ~(1u << j);
                        n = n & mask;
                    }
                    else
                    {
                        uint mask = 1u << j;
                        n = n | mask;
                    }
                }

                for (int m = q; m <= (q + k - 1); m++)
                {
                    if (bits[m - (q - p)] == 0)
                    {
                        uint mask = ~(1u << m);
                        n = n & mask;
                    }
                    else
                    {
                        uint mask = 1u << m;
                        n = n | mask;
                    }
                }

                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("overlapping");
            }
        }

    }
}