using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string endDots = new string('.', n - 1);
        Console.WriteLine("{0}{1}{0}", endDots, '*');
        for (int i = 1; i < n; i++)
        {
            endDots = new string('.', n - 1 - i);
            string middleDots = new string('.', 2 * n - 1 - 2 - 2 * (n - 1 - i));
            Console.WriteLine("{0}{1}{2}{1}{0}", endDots, '*', middleDots);
        }
        string asterisks = new string('*', 2 * n - 1);
        Console.WriteLine(asterisks);
        for (int i = 0; i < n/4; i++)
        {
            string middleDots = new string('.', 2 * n - 3);
            Console.WriteLine("{0}{1}{0}", '*', middleDots);
        }
        for (int i = 0; i < n/2; i++)
        {
            string window = new string('*', n - 3);
            string dots = new string('.', (2 * n - 1 - 2 - (n - 3))/2);
            Console.WriteLine("{0}{1}{2}{1}{0}", '*', dots, window);
        }
        for (int i = 0; i < n / 4; i++)
        {
            string middleDots = new string('.', 2 * n - 3);
            Console.WriteLine("{0}{1}{0}", '*', middleDots);
        }
        Console.WriteLine(asterisks);
    }
}