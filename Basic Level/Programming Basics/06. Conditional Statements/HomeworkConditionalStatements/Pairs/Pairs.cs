using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] elements = inputLine.Split(' ');
            int value = 0;
            int maxdiff = 0;

            if (elements.Length > 2)
            {
                for (int i = 0; i < elements.Length - 3; i = i + 2)
                {
                    int a = int.Parse(elements[i]);
                    int b = int.Parse(elements[i + 1]);
                    int c = int.Parse(elements[i + 2]);
                    int d = int.Parse(elements[i + 3]);

                    if (a + b == c + d)
                    {
                        value = a + b;
                    }
                    else
                    {
                        maxdiff = Math.Max(maxdiff, Math.Abs((a + b) - (c + d)));
                    }
                }

                if (maxdiff == 0)
                {
                    Console.WriteLine("Yes, value=" + value);
                }
                else
                {
                    Console.WriteLine("No, maxdiff=" + maxdiff);
                }
            }
            else
            {
                int a = int.Parse(elements[0]);
                int b = int.Parse(elements[1]); 
                Console.WriteLine("Yes, value=" + (a+b));
            }
        }
    }
}
