using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? myIntVariable = null;
        double? myDoubleVariable = null;
        Console.WriteLine(myIntVariable);
        Console.WriteLine(myDoubleVariable);

        myIntVariable = 2 + 3;
        myDoubleVariable = Math.Sqrt(2);
        Console.WriteLine(myIntVariable);
        Console.WriteLine(myDoubleVariable);
    }
}