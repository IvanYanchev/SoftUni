using System;

    class ProgrammerDNA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char startingLetter = Convert.ToChar(Console.ReadLine());
            int x = 3;
            int z = -1;
            for (int i = 0; i < n; i++)
            {

                string dots = new string('.', x);
                Console.Write("{0}", dots);
                for (int j = 0; j < (7 - 2 * x); j++)
                {
                    Console.Write(startingLetter);
                    startingLetter++;
                    if (startingLetter > 'G')
                    {
                        startingLetter = 'A';
                    }
                }
                Console.WriteLine("{0}", dots);
                x = x + z;
                if (x == 0 || x == 3)
                {
                    z = -z;
                }
            }
        }
    }