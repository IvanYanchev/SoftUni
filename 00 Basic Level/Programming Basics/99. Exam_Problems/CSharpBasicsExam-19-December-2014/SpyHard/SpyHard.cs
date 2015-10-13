using System;

    class SpyHard
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string massage = Console.ReadLine();

            char[] characters = massage.ToCharArray();
            int sum = 0;
            for (int i = 0; i < characters.Length; i++)
            {
                int charCode = (int)characters[i];
                if (charCode >= 65 && charCode <= 90)
                {
                    charCode = charCode - 64;
                }
                else if (charCode >= 97 && charCode <= 122)
                {
                    charCode = charCode - 96;
                }

                sum += charCode;
            }

            if (n != 10)
            {
                string sumToString = null;
                bool isConverted = true;
                do
                {
                    sumToString = sum % n + sumToString;
                    if(sum / n == 0)
                    {
                        isConverted = false;
                    }
                    sum = sum / n;
                } while (isConverted);

                Console.WriteLine("{0}{1}{2}", n, characters.Length, sumToString);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", n, characters.Length, sum);
            }
        }
    }