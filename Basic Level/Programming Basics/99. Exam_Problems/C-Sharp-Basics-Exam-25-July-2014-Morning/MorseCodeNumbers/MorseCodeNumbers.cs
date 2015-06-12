using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeNumbers
{
    class MorseCodeNumbers
    {
        static string GetMorse(int n)
        {
            string code = null;
            switch (n)
            {
                case 0: code = "-----"; break;
                case 1: code = ".----"; break;
                case 2: code = "..---"; break;
                case 3: code = "...--"; break;
                case 4: code = "....-"; break;
                case 5: code = "....."; break;
            }
            return code;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nSum = n / 1000 + (n / 100) % 10 + (n / 10) % 10 + n % 10;
            bool isFoundMorseCode = false;

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    for (int k = 1; k < 6; k++)
                    {
                        for (int l = 1; l < 6; l++)
                        {
                            for (int m = 1; m < 6; m++)
                            {
                                for (int o = 1; o < 6; o++)
                                {
                                    int morseProduct = i * j * k * l * m * o;
                                    if (morseProduct == nSum)
                                    {
                                        Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", GetMorse(i), GetMorse(j), GetMorse(k), GetMorse(l), GetMorse(m), GetMorse(o));
                                        isFoundMorseCode = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!isFoundMorseCode)
            {
                Console.WriteLine("No");
            }
        }
    }
}
