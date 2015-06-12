using System;

    class TheExplorer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) //cycle to transform into string and print each line of the diamond
            {
                int p = Math.Abs((n / 2) - i);
                int q = n - 2 * p - 2;
                string outerDashes = new string('-', p);
                if (q <= 0)
                {
                    string diamondLine = outerDashes + "*" + outerDashes;
                    Console.WriteLine(diamondLine);
                }
                else
                {
                    string innerDashes = new string('-', q);
                    string diamondLine = outerDashes + "*" + innerDashes + "*" + outerDashes;
                    Console.WriteLine(diamondLine);
                }

            }
                
        }
    }