using System;

class PrintLongSequence
{
    static void Main()
    {
        int sign = 1;
        for (int i = 2; i <= 1002; i++)
        {
            Console.Write("{0}, ", i * sign);
            sign = -sign;
        }

        Console.WriteLine();
    }
}