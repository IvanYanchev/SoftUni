using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        string result = string.Empty;
        do
        {
            result = convertDecToHexString(n % 16) + result;
            n = n / 16;

        } while (n != 0);

        Console.WriteLine(result);
    }

    static string convertDecToHexString(long m)
    {
        string ch = null;
        switch (m)
        {
            case 0: ch = "0"; break;
            case 1: ch = "1"; break;
            case 2: ch = "2"; break;
            case 3: ch = "3"; break;
            case 4: ch = "4"; break;
            case 5: ch = "5"; break;
            case 6: ch = "6"; break;
            case 7: ch = "7"; break;
            case 8: ch = "8"; break;
            case 9: ch = "9"; break;
            case 10: ch = "A"; break;
            case 11: ch = "B"; break;
            case 12: ch = "C"; break;
            case 13: ch = "D"; break;
            case 14: ch = "E"; break;
            case 15: ch = "F"; break;
        }
        return ch;
    }
}