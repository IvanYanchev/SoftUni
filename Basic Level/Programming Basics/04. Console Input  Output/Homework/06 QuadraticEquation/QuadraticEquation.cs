using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;

        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else
        {
            if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
        }
    }
}