using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0}{1}{0}", new string('.', n), '*'));

            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}", new string('.', n - i), '*', new string('.', 2 * i - 1)));
            }

            Console.WriteLine(string.Format("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1)));

            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}", new string('.', i), '*', new string('.', (2 * n + 1) - 2 * (i + 1))));
            }

            Console.WriteLine(string.Format("{0}{1}{2}{1}{2}{1}{0}", new string('.', n/2), '*', new string('.', n / 2 - 1)));

            for (int i = n / 2 - 1; i >= 1; i--)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', i), '*', new string('.', n / 2 - 1), new string('.', 2 * n + 1 - 4 - 2 * i - 2 * (n / 2 - 1))));
            }

            Console.WriteLine(string.Format("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1)));
        }
    }
}
