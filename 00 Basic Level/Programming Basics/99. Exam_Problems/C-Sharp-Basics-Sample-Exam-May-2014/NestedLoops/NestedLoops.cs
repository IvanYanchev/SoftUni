using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class NestedLoops
    {
        static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            int[] secretDigits = new int[4];
            int[] guessDigits = new int[4];
            bool isFoundGuessNumber = false;

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            guessDigits[0] = i;
                            guessDigits[1] = j;
                            guessDigits[2] = k;
                            guessDigits[3] = l;
                            for (int n = 0; n < 4; n++)
                            {
                                secretDigits[n] = (secretNumber / (int)(Math.Pow(10, 3 - n))) % 10;
                            }
                            int bullsCount = 0;
                            int cowsCount = 0;
                            for (int m = 0; m < 4; m++)
                            {
                                if (secretDigits[m] == guessDigits[m])
                                {
                                    bullsCount++;
                                    guessDigits[m] = 0;
                                    secretDigits[m] = 0;
                                }
                            }
                            for (int m = 0; m < 4; m++)
                            {
                                for (int n = 0; n < 4; n++)
                                {
                                    if (secretDigits[m] != 0 && m != n && secretDigits[m] == guessDigits[n])
                                    {
                                        cowsCount++;
                                        guessDigits[n] = 0;
                                        break;
                                    }
                                }
                            }
                            
                            if (bullsCount == bulls && cowsCount == cows)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, l);
                                isFoundGuessNumber = true;
                            }
                        }
                    }
                }
            }
            if (!isFoundGuessNumber)
            {
                Console.WriteLine("No");
            }
        }
    }
}
