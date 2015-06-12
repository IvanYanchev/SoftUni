using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string roofTopDots = new string('.', n);
            string roofTop = new string('*', n);
            Console.WriteLine("{0}{1}{0}", roofTopDots, roofTop);

            for (int i = 1; i <= n / 2 - 1; i++) 
            {
                string dotsEnd = new string('.', n - i);
                string dotsMiddle = new string('.', n + 2 * i - 2);
                Console.WriteLine("{0}{1}{2}{1}{0}", dotsEnd, '*', dotsMiddle);
            }

            string bodyEnd = new string('*', n / 2 + 1);
            string bodyMiddle = new string('.', 3 * n - 2 * (n / 2 + 1));
            Console.WriteLine("{0}{1}{0}", bodyEnd, bodyMiddle);

            for (int i = 0; i < n / 2 - 2; i++)
            {
                bodyMiddle = new string('.', 3 * n - 2);
                Console.WriteLine("{0}{1}{0}", '*', bodyMiddle);
            }

            Console.WriteLine("{0}", new string('*', 3 * n));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                string dotsEnd = new string('.', n/2);
                char ch = '.';
                if (i == n / 2 - 2)
                {
                    ch = '*';
                }
                string dotsTires = new string(ch, n / 2 - 1);
                string dotsMiddle = new string('.', n - 2);
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", dotsEnd, '*', dotsTires, dotsMiddle);
            }


        }
    }
}
