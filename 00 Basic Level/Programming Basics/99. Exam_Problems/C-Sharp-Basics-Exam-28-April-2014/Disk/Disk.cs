using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    double dist = Math.Sqrt(Math.Pow((x - n / 2), 2) + Math.Pow((y - n / 2), 2));
                    char ch = '.';
                    if (dist <= r)
                    {
                        ch = '*';
                    }
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }
    }
}
