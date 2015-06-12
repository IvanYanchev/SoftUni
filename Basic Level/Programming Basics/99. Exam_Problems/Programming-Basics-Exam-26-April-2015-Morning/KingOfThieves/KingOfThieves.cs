using System;

    class KingOfThieves
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char ch = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < n/2; i++)
            {
                string dash = new string('-', n / 2 - i);
                string gem = new string(ch, n - 2 * (n / 2 - i));
                Console.WriteLine("{0}{1}{0}", dash, gem);
            }
            for (int i = n/2 ; i >= 0; i--)
            {
                string dash = new string('-', n / 2 - i);
                string gem = new string(ch, n - 2 * (n / 2 - i));
                Console.WriteLine("{0}{1}{0}", dash, gem);
            }
        }
    }