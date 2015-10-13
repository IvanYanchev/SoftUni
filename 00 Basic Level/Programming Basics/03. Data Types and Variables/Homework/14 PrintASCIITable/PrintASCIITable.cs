using System;
using System.Text;

class PrintASCIITable
{
    static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.ASCII;
            for (int i = 0; i <= 255; i++)
            {
                char asciiSymbol = (char)i;
                Console.WriteLine("ASCII code {0} -> {1}", i, asciiSymbol);
            }           
        }
}