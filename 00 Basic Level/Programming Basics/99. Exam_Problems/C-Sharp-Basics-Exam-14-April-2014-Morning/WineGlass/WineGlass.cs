using System;

    class WineGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                string dots = new string('.', i);
                string asterisks = new string('*', n - 2 * (i + 1));
                Console.WriteLine("{0}{1}{2}{3}{0}", dots, '\\', asterisks, '/', dots);
            }

            int bottom = 0;
            if (n >= 12)
            {
                bottom = n / 2 - 2;
            }
            else
            {
                bottom = n / 2 - 1;
            }
            for (int i = 0; i < bottom; i++)
            {
                string dots = new string('.', (n - 2) / 2);
                Console.WriteLine("{0}{1}{1}{0}", dots, '|');
            }
            for (int i = 0; i < n/2 - bottom; i++)
            {
                string dashes = new string('-', n);
                Console.WriteLine(dashes);
            }

        }
    }