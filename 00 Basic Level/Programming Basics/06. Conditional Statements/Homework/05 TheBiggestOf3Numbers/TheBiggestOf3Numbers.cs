using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        double maxNumber = 0;

        if (a >= b && a >= c)
        {
            maxNumber = a;
        }
        if (b >= a && b >= c)
        {
            maxNumber = b;
        }
        if (c >= a && c >= b)
        {
            maxNumber = c;
        }
        Console.WriteLine("The biggest number is: {0}", maxNumber);
    }
}
