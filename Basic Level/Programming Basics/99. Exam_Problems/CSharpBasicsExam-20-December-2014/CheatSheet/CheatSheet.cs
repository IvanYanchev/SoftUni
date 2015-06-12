using System;

    class CheatSheet
    {
        static void Main()
        {
            decimal numberOfRows = decimal.Parse(Console.ReadLine());
            decimal numberOfCols = decimal.Parse(Console.ReadLine());
            decimal rowStartNumber = decimal.Parse(Console.ReadLine());
            decimal colStartNumber = decimal.Parse(Console.ReadLine());

            for (decimal i = rowStartNumber; i < rowStartNumber + numberOfRows; i++)
            {
                for (decimal j = colStartNumber; j < colStartNumber + numberOfCols; j++)
                {
                    string space = " ";
                    if (j == colStartNumber + numberOfCols - 1)
                    {
                        space = null;
                    }
                    Console.Write("{0}{1}", i * j, space);
                }
                Console.WriteLine();
            }
        }
    }