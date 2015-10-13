using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3dSpace
{
    class Program
    {
        static void Main()
        {
            Point3D pointA = new Point3D(2, -13.5, 57.2);
            Point3D pointB = new Point3D(-0.6, -24, 12);

            double distance = DistanceCalculator3D.CalculateDistanceBetweenTwoPoints(pointA, pointB);

            Console.WriteLine("{0:F2}", distance);
        }
    }
}
