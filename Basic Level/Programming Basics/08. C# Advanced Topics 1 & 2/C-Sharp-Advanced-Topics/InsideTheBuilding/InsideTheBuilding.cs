using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x;
            int y;
            for (int i = 0; i < 5; i++)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (((x >= 0 && x <= 3 * h) && (y >= 0 && y <= h)) || ((x >= h && x <= 2 * h) && (y >= h && y <= 4 * h)))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
