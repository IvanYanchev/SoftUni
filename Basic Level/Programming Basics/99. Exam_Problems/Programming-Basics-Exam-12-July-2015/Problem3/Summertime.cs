using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summertime
{
    class Summertime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topEnd = new string(' ', n / 2);
            string topMiddle = new string('*', n + 1);

            Console.WriteLine(string.Format("{0}{1}{0}", topEnd, topMiddle));

            for (int i = 0; i < n / 2; i++)
            {
                topMiddle = new string(' ', n - 1);
                topMiddle = '*' + topMiddle + '*';
                Console.WriteLine(string.Format("{0}{1}{0}", topEnd, topMiddle));
            }

            for (int i = 0; i <= n/2 - 1; i++)
            {
                topEnd = new string(' ', n / 2 - i);
                topMiddle = new string(' ', n - 1 + 2 * i);
                topMiddle = '*' + topMiddle + '*';
                Console.WriteLine(string.Format("{0}{1}{0}", topEnd, topMiddle));
            }

            for (int i = 0; i < 2 * n; i++)
            {
                char fillSymbol;
                if (i < n)
                {
                    fillSymbol = '.';
                }
                else
                {
                    fillSymbol = '@';
                }
                string upperHalfBottle = string.Format("{0}{1}{0}", '*', new string(fillSymbol, 2 * n - 2));
                Console.WriteLine(upperHalfBottle);
            }

            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
