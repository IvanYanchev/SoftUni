using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        double circleRadius = 1.5;
        double circleCenterX = 1;
        double circleCenterY = 1;
        double rectangleTop = 1;
        double rectangleLeft = -1;
        double rectangleWidth = 6;
        double rectangleHeight = 2;

        Console.Write("Enter coordinate X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate Y: ");
        double y = double.Parse(Console.ReadLine());
        double dist = Math.Sqrt((x - circleCenterX) * (x - circleCenterX) + (y - circleCenterY) * (y - circleCenterY));
        bool isInsideTheCircle = dist <= circleRadius;

        bool isInsideTheRecatngle = 
            x >= rectangleLeft && 
            x <= rectangleLeft + rectangleWidth && 
            y >= rectangleTop - rectangleHeight && 
            y <= rectangleTop;

        bool result = isInsideTheCircle && !isInsideTheRecatngle;

        Console.WriteLine("Is the point within the circle K({{{0}, {1}}}, {2}) and out of the rectangle R(top={3}, left={4}, width={5}, height={6}): {7}", circleCenterX, circleCenterY, circleRadius, rectangleTop, rectangleLeft, rectangleWidth, rectangleHeight, result);
    }
}
