using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value v: ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result = 0;

        if (v == 0)
        {
            mask = ~mask;
            result = n & mask;
        }
        else
        {
            result = n | mask;
        }

        Console.WriteLine("Result: ", result);
    }
}