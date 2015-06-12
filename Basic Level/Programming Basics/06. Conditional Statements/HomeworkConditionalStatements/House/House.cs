using System;

    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string roofOuterDots = new string('.', n / 2);
            Console.WriteLine("{0}{1}{0}", roofOuterDots, '*');
 
            for (int i = 1; i < n / 2; i++)
            {
                roofOuterDots = new string('.', n / 2 - i);
                string roofInnerDots = new string('.', n - 2 - 2 * (n / 2 - i));
                Console.WriteLine("{0}{1}{2}{1}{0}", roofOuterDots, '*', roofInnerDots);
            }

            string roofBase = new string('*', n);
            Console.WriteLine(roofBase);

            for (int i = 1; i < n / 2; i++)
            {
                string houseOuterDots = new string('.', n / 4);
                string houseInnerDots = new string('.', n - 2 - 2 * (n / 4));
                Console.WriteLine("{0}{1}{2}{1}{0}", houseOuterDots, '*', houseInnerDots);
            }

            string houseBase = new string('*', n - 2 * (n / 4));
            string baseDots = new string('.', n / 4);
            Console.WriteLine("{0}{1}{0}", baseDots, houseBase);
        }
    }