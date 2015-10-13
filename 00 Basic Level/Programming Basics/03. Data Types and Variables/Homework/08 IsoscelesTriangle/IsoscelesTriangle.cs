using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char ch = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("   " + ch);
        Console.WriteLine("  " + ch + " " + ch);
        Console.WriteLine(" " + ch + "   " + ch);
        Console.WriteLine(ch + " " + ch + " " + ch + " " + ch);
    }
}