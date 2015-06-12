using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string dotsTopBottom = new string('.', (3 * n - 1) / 2);
            Console.WriteLine("{0}{1}{0}", dotsTopBottom, '*');

            for (int i = 1; i < n; i++)
            {
                string dotsEnd = new string('.', i);
                string dotsBetweenRays = new string('.', (3 * n - 2 * i - 3) / 2);
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", dotsEnd, '*', dotsBetweenRays);
            }
            for (int i = 0; i < n; i++)
            {
                string dotsEnd = null;
                if (i == n /2 ) dotsEnd = new string('*', n);
                else dotsEnd = new string('.', n);

                string asteriskSun = new string('*', n);
                Console.WriteLine("{0}{1}{0}", dotsEnd, asteriskSun);
            }
            for (int i = n-1; i >=1; i--)
            {
                string dotsEnd = new string('.', i);
                string dotsBetweenRays = new string('.', (3 * n - 2 * i - 3) / 2);
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", dotsEnd, '*', dotsBetweenRays);
            }
            Console.WriteLine("{0}{1}{0}", dotsTopBottom, '*');
        }
    }
}
