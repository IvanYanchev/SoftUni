using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long[] numbers = input.Split(' ').Select(long.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i += 2)
            {
                for (int evenBitPosition = 0; evenBitPosition < 64; evenBitPosition += 2)
                {
                    long bitAtEvenPositionFirstNumber = (numbers[i] >> evenBitPosition) & 1L;
                    long bitAtEvenPositionSecondNumber = (numbers[i + 1] >> evenBitPosition) & 1L;

                    numbers[i] = SetBitAtPosition(numbers[i], bitAtEvenPositionSecondNumber, evenBitPosition);
                    numbers[i + 1] = SetBitAtPosition(numbers[i + 1], bitAtEvenPositionFirstNumber, evenBitPosition);
                }

                numbers[i] = ~numbers[i];
                numbers[i + 1] = ~numbers[i + 1];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = SetBitAtPosition(numbers[i], 0L, 63);
                Console.WriteLine("{0} {1}", numbers[i], Convert.ToString(numbers[i], 2).PadLeft(63, '0'));
            }
        }

        static long SetBitAtPosition(long number, long bit, int position)
        {
            if (bit == 0)
            {
                number = number & ~(1L << position);
            }
            else
            {
                number = number | (1L << position);
            }

            return number;
        }
    }
}
