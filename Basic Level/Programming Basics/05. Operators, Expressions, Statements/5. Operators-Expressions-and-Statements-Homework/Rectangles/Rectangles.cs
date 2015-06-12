using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter rectangle’s width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter rectangle’s height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("Rectangle’s perimeter is {0}", perimeter);
        Console.WriteLine("Rectangle’s area is {0}", area);
    }
}