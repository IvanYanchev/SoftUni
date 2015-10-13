using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Magic_Wand
{
    class MagicWand
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string topEndDots = new string('.', (3 * n + 1) / 2);
            Console.WriteLine(string.Format("{0}{1}{0}", topEndDots, '*'));

            for (int i = 0; i < n / 2 + 1; i++)
            {
                int midDotsNum = 2 * i + 1;
                string endDots = new string('.', (3 * n - midDotsNum) / 2);
                string midDotsString = new string('.', midDotsNum);
                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}", endDots, '*', midDotsString));
            }

            string midEndAst = new string('*', n);
            string midMidDots = new string('.', n + 2);
            Console.WriteLine(string.Format("{0}{1}{0}", midEndAst,midMidDots));

            for (int i = 1; i <= n / 2; i++)
            {
                string endDots = new string('.', i);
                string midDots = new string('.', 3 * n - 2 * i);
                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}", endDots, '*', midDots));
            }

            string holdDots = new string('.', n);

            for (int i = n / 2 - 1; i >= 0; i--) 
            {
                string endDots = new string('.', i);
                string rayDots = new string('.', n / 2);
                string midDots = new string('.', (n / 2 - 1) - i);
                Console.WriteLine(string.Format("{0}{1}{2}{1}{3}{1}{4}{1}{3}{1}{2}{1}{0}", endDots, '*', rayDots, midDots, holdDots));
            }

            string endAst = new string('*', n / 2 + 1);
            string betweenDots = new string('.', n / 2);
            Console.WriteLine(string.Format("{0}{1}{2}{3}{2}{1}{0}", endAst, betweenDots, '*', holdDots));

            for (int i = 0; i <= n; i++)
            {
                string midDots = holdDots;

                if (i == n)
                {
                    midDots = new string('*', n);
                }

                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}", holdDots, '*', midDots));
            }
        }
    }
}
