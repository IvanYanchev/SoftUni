using System;

class ExtractBit3
{
    static void Main()
    {
        int positionOfBitToExtract = 3;
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int mask = 1;
        int result = (n >> positionOfBitToExtract) & mask;
        Console.WriteLine("Bit at position {0}: {1}", positionOfBitToExtract, result);
    }
}