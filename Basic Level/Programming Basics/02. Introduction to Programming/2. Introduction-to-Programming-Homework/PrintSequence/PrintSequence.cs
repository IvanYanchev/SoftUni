using System;

class PrintSequence
{
    static void Main()
    {
        int a = 2;
        int b = 1;

        for (int i = 0; i < 10; i++)
        {
            Console.Write(a * b + ", ");
            a = a + 1;
            b = -b;
        }

        Console.WriteLine();
    }
}