using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDowns
{
    class DoubleDowns
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int countRightDiagonal = 0;
            int countLeftDiagonal = 0;
            int countVertical = 0;

            for (int i = 1; i < n; i++)
            {
                for (int position = 0; position < 32; position++)
                {
                    if (BitAtPosition(nums[i], position) == 1)
	                {
                        if (BitAtPosition(nums[i], position) == BitAtPosition(nums[i - 1], position))
                        {
                            countVertical++;
                        }
                        if (position > 0 && BitAtPosition(nums[i], position) == BitAtPosition(nums[i - 1], position - 1))
                        {
                            countLeftDiagonal++;
                        }
                        if (position < 31 && BitAtPosition(nums[i], position) == BitAtPosition(nums[i - 1], position + 1))
                        {
                            countRightDiagonal++;
                        }
	                }
                }
            }

            Console.WriteLine(countRightDiagonal);
            Console.WriteLine(countLeftDiagonal);
            Console.WriteLine(countVertical);
        }

        static int BitAtPosition(int num, int position)
        {
            int mask = 1 << position;
            int bit = num & mask;
            return bit >> position;
        }
    }
}
