using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int isFoundMagicNumber = 0;

        for (int a = 1; a <= 7; a++)
        {
            for (int b = 1; b <= 7; b++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    for (int d = 1; d <= 7; d++)
                    {
                        for (int e = 1; e <= 7; e++)
                        {
                            for (int f = 1; f <= 7; f++)
                            {
                                for (int g = 1; g <= 7; g++)
                                {
                                    for (int h = 1; h <= 7; h++)
                                    {
                                        for (int i = 1; i <= 7; i++)
                                        {
                                            int abc = 100 * a + 10 * b + c;
                                            int def = 100 * d + 10 * e + f;
                                            int ghi = 100 * g + 10 * h + i;
                                            if (a + b + c + d + e + f + g + h + i == sum && ghi - def == diff && def - abc == diff && abc <= def && def <= ghi)
                                            {
                                                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                                isFoundMagicNumber = isFoundMagicNumber + 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (isFoundMagicNumber == 0)
        {
            Console.WriteLine("No");
        }
    }
}