using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        bool isNotValidNumber;

        do
        {
            Console.Write("Въведете цяло число а: ");
            isNotValidNumber = !int.TryParse(Console.ReadLine(), out a);

            if (isNotValidNumber)
            {
                Console.WriteLine("Невалидна стойност!");
            }

        } while (isNotValidNumber);


        string aBinary = Convert.ToString(a, 2);

        Console.Write("Въведете реално число b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Въведете реално число c: ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:F3}|", a, aBinary.PadLeft(10, '0'), b, c);
    }
}