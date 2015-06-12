using System;

class QuotesInStrings
{
    static void Main()
    {
        string myStringVar1 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(myStringVar1);

        string myStringVar2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(myStringVar2);
    }
}