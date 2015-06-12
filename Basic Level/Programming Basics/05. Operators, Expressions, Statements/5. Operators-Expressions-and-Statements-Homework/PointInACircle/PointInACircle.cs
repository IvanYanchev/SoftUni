using System;

class PointInACircle
{
    static void Main()
    {
        int circleRadius = 2;
        Console.WriteLine("Enter coordinates to check if the point is inside the circle K({{0, 0}}, {0})", circleRadius);
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());
        double distToCenter = Math.Sqrt(x * x + y * y);
        Console.WriteLine("Result : {0}", distToCenter <= circleRadius);
    }
}