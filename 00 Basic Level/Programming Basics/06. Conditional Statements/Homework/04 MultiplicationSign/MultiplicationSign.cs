using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string result = string.Empty;

        if (a == 0 || b == 0 || c == 0)
        {
            result = "0";
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            result = "-";
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            result = "+";
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            result = "-";
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            result = "+";
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            result = "+";
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            result = "-";
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            result = "+";
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            result = "-";
        }

        Console.WriteLine("The result is \"{0}\"", result);
    }
}