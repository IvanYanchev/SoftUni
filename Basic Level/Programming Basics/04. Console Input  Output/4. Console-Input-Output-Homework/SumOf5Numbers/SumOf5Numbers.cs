using System;
using System.Collections;
using System.Linq;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine(Console.ReadLine().Split(' ').Select(double.Parse).Sum());
    }
}