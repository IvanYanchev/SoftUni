using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Car_Numbers
{
    class MagicCarNumbers
    {
        static void Main(string[] args)
        {
            int magicWeight = int.Parse(Console.ReadLine());
            char[] suffixLetters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int n = 0; n < 10; n++)
                                {
                                    if ((i == j && j == k && k == l) || (i == j && j == k) || (j == k && k == l) || (i == j && k == l) || (i == k && j == l) || (i == l && j == k))
                                    {
                                        int carNumberWeight = 30 + 10 + i + j + k + l + (suffixLetters[m] - 64) * 10 + (suffixLetters[n] - 64) * 10;
                                        if (carNumberWeight == magicWeight)
                                        {
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}