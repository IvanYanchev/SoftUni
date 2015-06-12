using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFlipper
{
    class BitFlipper
    {
        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            int position = 61;

            do
            {
                ulong bit1 = bitOnPositionZ(num, position);
                ulong bit2 = bitOnPositionZ(num, position + 1);
                ulong bit3 = bitOnPositionZ(num, position + 2);
                if (bit1 == bit2 && bit2 == bit3)
                {
                    num = bitFlip(num, position, bit1);
                    num = bitFlip(num, position + 1, bit2);
                    num = bitFlip(num, position + 2, bit3);
                    position -= 3;
                }
                else
                {
                    position -= 1;
                }
            } while (position >=0 );
            Console.WriteLine(num);

        }

        static ulong bitOnPositionZ (ulong n, int position)
        {
            ulong mask = 1UL << position;
            ulong bit = (n & mask) >> position;
            return bit;
        }

        static ulong bitFlip (ulong num, int position, ulong bit)
        {
            switch (bit)
            {
                case 0: num = num | (1UL << position);
                    break;
                case 1: num = num & ~(1UL << position);
                    break;
            }
            return num;
        }
    }
}
