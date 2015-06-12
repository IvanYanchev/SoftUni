using System;

    class BitRoller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            
            int leftmost = 18;
            if (f == 18) leftmost = 17;

            for (int i = 0; i < r; i++)
			{
                int frozenBit = ((1 << f) & n) >> f;
                int firstToTheLeftFromFrozenBit = ((1 << f + 1) & n) >> f + 1;
                int rightmostBitToBeMovedLeftmost = 1 & n;
                n = n >> 1;
                n = bitMover(frozenBit, n, f);
                if (f == 0) n = bitMover(firstToTheLeftFromFrozenBit, n, leftmost);
                else n = bitMover(firstToTheLeftFromFrozenBit, n, f - 1);
                if (f != 0) n = bitMover(rightmostBitToBeMovedLeftmost, n, leftmost);
			}
            Console.WriteLine(n);
        }

        static int bitMover(int bit, int num, int position)
        {
            if (bit == 0)
            {
                num = num & ~(1 << position);
            }
            else
            {
                num = num | (1 << position);
            }
            return num;
        }
    }