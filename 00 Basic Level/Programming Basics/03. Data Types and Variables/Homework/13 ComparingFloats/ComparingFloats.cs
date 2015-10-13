using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Input Number a: ");
        double numberA = double.Parse(Console.ReadLine());

        Console.Write("Input Number b: ");
        double numberB = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        double delta = Math.Abs(numberA - numberB);
        bool isEqual = delta < eps;

        Console.WriteLine("a = b -> {0}", isEqual);
    }
}
