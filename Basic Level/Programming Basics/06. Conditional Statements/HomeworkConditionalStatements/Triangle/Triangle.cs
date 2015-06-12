using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int aXcoordinate = int.Parse(Console.ReadLine());
            int aYcoordinate = int.Parse(Console.ReadLine());
            int bXcoordinate = int.Parse(Console.ReadLine());
            int bYcoordinate = int.Parse(Console.ReadLine());
            int cXcoordinate = int.Parse(Console.ReadLine());
            int cYcoordinate = int.Parse(Console.ReadLine());

            double distAB = Math.Sqrt(Math.Pow((bXcoordinate - aXcoordinate), 2) + Math.Pow((bYcoordinate - aYcoordinate), 2));
            double distBC = Math.Sqrt(Math.Pow((cXcoordinate - bXcoordinate), 2) + Math.Pow((cYcoordinate - bYcoordinate), 2));
            double distAC = Math.Sqrt(Math.Pow((cXcoordinate - aXcoordinate), 2) + Math.Pow((cYcoordinate - aYcoordinate), 2));

            if (distAB < (distAC+distBC) && distAC < (distAB + distBC) && distBC < (distAB + distAC))
            {
                double p = (distAB + distAC + distBC) / 2;
                double area = Math.Sqrt(p * (p - distAB) * (p - distAC) * (p - distBC));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", distAB);
            }
        }
    }
}
