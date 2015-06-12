using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Interfaces;

namespace Shapes
{
    class ShapesMain
    {
        static void Main(string[] args)
        {
            IShape[] shapes = 
            {
                new Circle(4.56),
                new Triangle(2.4, 6.7),
                new Rectangle(5.8, 3.75),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}, Area: {1:F2}, Perimeter: {2:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
