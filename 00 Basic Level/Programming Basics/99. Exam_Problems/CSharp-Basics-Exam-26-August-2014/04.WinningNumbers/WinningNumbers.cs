using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WinningNumbers
{
    class WinningNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int letSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                letSum += input[i] - 'a' + 1;
            }

            bool isNotFoundWinningNumber = true;

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            for (int m = 1; m < 10; m++)
                            {
                                for (int n = 1; n < 10; n++)
                                {
                                    int productLeft = i * j * k;
                                    int productRight = l * m * n;
                                    if (productLeft == productRight && productLeft == letSum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}", i, j, k, l, m, n);
                                        isNotFoundWinningNumber = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (isNotFoundWinningNumber)
            {
                Console.WriteLine("No");
            }
        }
    }
}
