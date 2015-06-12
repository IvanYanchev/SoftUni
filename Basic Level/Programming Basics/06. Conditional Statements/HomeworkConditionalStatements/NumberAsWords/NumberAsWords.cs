using System;

    class NumberAsWords
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int hundreds = num / 100;
            int tenths = (num % 100) / 10;
            int ones = (num % 100) % 10;
            string numberAsWords = null;

            if (hundreds != 0)
            {
                numberAsWords += DigitToWord(hundreds) + " hundreds and ";
            }
            if (tenths > 1)
            {
                    switch (tenths)
                    {
                        case 2: numberAsWords += "twenty "; break;
                        case 3: numberAsWords += "thirty "; break;
                        case 4: numberAsWords += "fourty "; break;
                        case 5: numberAsWords += "fifty "; break;
                        case 6: numberAsWords += "sixty "; break;
                        case 7: numberAsWords += "seventy "; break;
                        case 8: numberAsWords += "eighty "; break;
                        case 9: numberAsWords += "ninety "; break;
                    }
                    numberAsWords += DigitToWord(ones);
            }
            else if (tenths == 1 && ones == 0)
                {
                    numberAsWords += " ten ";
                }
                else
                {
                    switch (ones)
                    {
                        case 1: numberAsWords += "eleven "; break;
                        case 2: numberAsWords += "twelve "; break;
                        case 3: numberAsWords += "thirteen "; break;
                        case 4: numberAsWords += "fourteen "; break;
                        case 5: numberAsWords += "fifteen "; break;
                        case 6: numberAsWords += "sixteen "; break;
                        case 7: numberAsWords += "seventeen "; break;
                        case 8: numberAsWords += "eighteen "; break;
                        case 9: numberAsWords += "nineteen "; break;
                    }
                }
            

            Console.WriteLine(numberAsWords);
        }

        static string DigitToWord(int digit)
        {
            string digitWord = null;

            switch (digit)
            {
                case 1: digitWord = "one"; break;
                case 2: digitWord = "two"; break;
                case 3: digitWord = "three"; break;
                case 4: digitWord = "four"; break;
                case 5: digitWord = "five"; break;
                case 6: digitWord = "six"; break;
                case 7: digitWord = "seven"; break;
                case 8: digitWord = "eight"; break;
                case 9: digitWord = "nine"; break;
            }

            return digitWord;
        }
                  
    }