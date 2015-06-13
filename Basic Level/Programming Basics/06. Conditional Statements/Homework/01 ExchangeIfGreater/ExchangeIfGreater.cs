using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double b = double.Parse(Console.ReadLine());
        double c;
        bool aIsBiggerThanB = a > b;

        if (aIsBiggerThanB)
        {
            Console.Write("a is bigger than b (a and b swaped): ");
            c = a;
            a = b;
            b = c;
        }
        else
        {
            Console.Write("b is bigger than a (a and b unchanged): ");
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}