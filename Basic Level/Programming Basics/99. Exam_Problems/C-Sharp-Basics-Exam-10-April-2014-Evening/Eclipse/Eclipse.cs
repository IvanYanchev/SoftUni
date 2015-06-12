using System;

    class Eclipse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string topAndBottomFrame = new string('*', n * 2 - 2);
            string topAndBottomMiddleSpaces = new string(' ', n + 1);
            Console.WriteLine("{0}{1}{2}{1}{0}", ' ', topAndBottomFrame, topAndBottomMiddleSpaces);
            for (int i = 0; i < n -2; i++)
            {
                string lenses = new string('/', n * 2 - 2);
                char bridgeChar;
                if (i == (n - 2)/ 2)
                {
                    bridgeChar = '-';
                }
                else
                {
                    bridgeChar = ' ';
                }
                string middle = new string(bridgeChar, n - 1);
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', lenses, middle);
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", ' ', topAndBottomFrame, topAndBottomMiddleSpaces);
        }
    }