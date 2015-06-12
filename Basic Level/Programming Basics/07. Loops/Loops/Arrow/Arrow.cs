using System;

    class Arrow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string arrowTopEndDots = new string('.', n/2);
            string arrowTopSharps = new string('#', n);
            Console.WriteLine("{0}{1}{0}", arrowTopEndDots, arrowTopSharps);
            string arrowTopMiddleDots = new string('.', n - 2);

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", arrowTopEndDots, '#', arrowTopMiddleDots);
            }

            string arrowBottomSharps = new string('#', n / 2 + 1);
            Console.WriteLine("{0}{1}{0}", arrowBottomSharps,arrowTopMiddleDots);

            for (int i = 1; i <= n-2; i++)
            {
                string arrowBottomEndDots = new string('.', i);
                string arrowBottomMiddleDots = new string('.', (2 * n - 1) - 2 - (2 * i));
                Console.WriteLine("{0}{1}{2}{1}{0}", arrowBottomEndDots, '#', arrowBottomMiddleDots);
            }

            string arrowBottomDots = new string('.', (2 * n - 1) / 2);
            Console.WriteLine("{0}{1}{0}", arrowBottomDots, '#');
        }
    }