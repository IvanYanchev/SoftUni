using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter index of bit to extract: ");
        int positionOfBitToExtract = int.Parse(Console.ReadLine());
        int mask = 1;
        int result = (n >> positionOfBitToExtract) & mask;
        Console.WriteLine("Bit at position {0}: {1}", positionOfBitToExtract, result);
    }
}