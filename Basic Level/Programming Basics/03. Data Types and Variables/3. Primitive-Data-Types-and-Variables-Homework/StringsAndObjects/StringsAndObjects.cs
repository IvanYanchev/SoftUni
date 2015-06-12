using System;

class StringsAndObjects
{
    static void Main()
    {
        string varString1 = "Hello";
        string varString2 = "World";
        string varString3;
        object varObject = varString1 + " " + varString2;

        varString3 = (string)varObject;
        Console.WriteLine(varString3);
    }
}