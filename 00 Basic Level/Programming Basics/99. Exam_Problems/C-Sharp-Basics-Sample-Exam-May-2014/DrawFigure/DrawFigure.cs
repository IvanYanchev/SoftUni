using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigure
{
    class DrawFigure
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n/2; i++)
            {
                string dots = new string('.', i);
                string asterisks = new string('*', n - 2 * i);
                Console.WriteLine("{0}{1}{0}", dots, asterisks);
            }

            for (int i = n/2 - 1; i >= 0; i--)
            {
                string dots = new string('.', i);
                string asterisks = new string('*', n - 2 * i);
                Console.WriteLine("{0}{1}{0}", dots, asterisks);
            }
        }
    }
}
