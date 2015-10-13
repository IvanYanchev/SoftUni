using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanNumbers
{
    class HayvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool isNotFoundHayvanNumber = true;

            for (int a = 5; a < 10; a++)
            {
                for (int b = 5; b < 10; b++)
                {
                    for (int c = 5; c < 10; c++)
                    {
                        for (int d = 5; d < 10; d++)
                        {
                            for (int e = 5; e < 10; e++)
                            {
                                for (int f = 5; f < 10; f++)
                                {
                                    for (int g = 5; g < 10; g++)
                                    {
                                        for (int h = 5; h < 10; h++)
                                        {
                                            for (int i = 5; i < 10; i++)
                                            {
                                                if ((a + b + c + d + e + f + g + h + i == sum) &&
                                                   ((g * 100 + h * 10 + i) - (d * 100 + e * 10 + f) == diff) && ((d * 100 + e * 10 + f) - (a * 100 + b * 10 + c) == diff) &&
                                                   ((a * 100 + b * 10 + c) <= (d * 100 + e * 10 + f) && (d * 100 + e * 10 + f) <= (g * 100 + h * 10 + i)))
                                                {
                                                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", a, b, c, d, e, f, g, h, i);
                                                    isNotFoundHayvanNumber = false;
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
            if (isNotFoundHayvanNumber) Console.WriteLine("No");
        }
    }
}
