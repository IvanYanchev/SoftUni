using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("Input length of side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input length of side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input height h: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) * h) / 2;
        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}