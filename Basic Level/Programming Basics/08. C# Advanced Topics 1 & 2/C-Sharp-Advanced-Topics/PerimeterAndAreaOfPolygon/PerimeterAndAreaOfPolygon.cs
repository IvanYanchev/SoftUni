using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterAndAreaOfPolygon
{
    class PerimeterAndAreaOfPolygon
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            Point[] perimeter = new Point[n];
            for (int i = 0; i < n; i++)
            {
                string inputLineCoordinates = Console.ReadLine();
                string[] coordinates = inputLineCoordinates.Split(' ');
                perimeter[i] = new Point() { x = int.Parse(coordinates[0]), y = int.Parse(coordinates[1]) };
            }
            double perimeterLenght = 0.0;
            double areaLenght = 0.0;
            for (int i = 0; i < n; i++)
            {
                double a;
                double b;
                if (i == n-1)
                {
                    a = Math.Sqrt(Math.Pow((perimeter[i].x - perimeter[0].x), 2) + Math.Pow((perimeter[i].y - perimeter[0].y), 2));
                    b = perimeter[i].x * perimeter[0].y - perimeter[i].y * perimeter[0].x;
                }
                else
                {
                    a = Math.Sqrt(Math.Pow((perimeter[i].x - perimeter[i + 1].x), 2) + Math.Pow((perimeter[i].y - perimeter[i + 1].y), 2));
                    b = perimeter[i].x * perimeter[i+1].y - perimeter[i].y * perimeter[i+1].x;
                }
                perimeterLenght += a;
                areaLenght += b;
            }
            Console.WriteLine("perimeter = {0:F2}", perimeterLenght);
            Console.WriteLine("area = {0:F2}", Math.Abs(areaLenght / 2));
        }   
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
