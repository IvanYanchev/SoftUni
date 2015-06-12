using System;

class BitShooter
{
    static void Main()
    {
        ulong bitField = ulong.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            string shoot = Console.ReadLine();
            string[] centerSize = shoot.Split(' ');
            int center = int.Parse(centerSize[0]);
            int size = int.Parse(centerSize[1]);

            for (int bitPosition = center - size / 2; bitPosition <= center + size / 2; bitPosition++)
            {
                if (bitPosition >= 0 && bitPosition <= 63)
                {
                    bitField = bitField & ~(1ul << bitPosition);
                }
            }
        }

        int countLeft = 0;
        int countRight = 0;

        for (int i = 0; i < 64; i++)
        {
            ulong survivedBit = (bitField & 1ul << i) >> i;
            if (survivedBit == 1 && i < 32)
            {
                countRight++;
            }
            else if (survivedBit == 1 && i >= 32)
            {
                countLeft++;
            }
        }
        Console.WriteLine("left: {0}", countLeft);
        Console.WriteLine("right: {0}", countRight);
    }
}