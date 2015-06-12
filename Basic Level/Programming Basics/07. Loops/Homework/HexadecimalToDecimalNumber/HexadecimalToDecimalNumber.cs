using System;

class HexidecimalToDecimalNumber
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        long result = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            string numberHex = inputString.Substring(i, 1);
            int numberDec = 0;

            switch (numberHex)
            {
                case "0": numberDec = 0; break;
                case "1": numberDec = 1; break;
                case "2": numberDec = 2; break;
                case "3": numberDec = 3; break;
                case "4": numberDec = 4; break;
                case "5": numberDec = 5; break;
                case "6": numberDec = 6; break;
                case "7": numberDec = 7; break;
                case "8": numberDec = 8; break;
                case "9": numberDec = 9; break;
                case "A": numberDec = 10; break;
                case "B": numberDec = 11; break;
                case "C": numberDec = 12; break;
                case "D": numberDec = 13; break;
                case "E": numberDec = 14; break;
                case "F": numberDec = 15; break;
            }

            result += (long)Math.Pow(16, inputString.Length - i - 1) * numberDec;
        }

        Console.WriteLine(result);
    }
}