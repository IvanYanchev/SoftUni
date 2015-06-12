using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine("a = {0}; b = {1}", a, b); //Prints the initialized values of a and b

        c = b; //Switching the values
        b = a; //of variables a and b
        a = c; //using additional variable c
        Console.WriteLine("a = {0}; b = {1}", a, b);
    }
}
