using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Please input your birthday YYYY-MM-DD: ");
        DateTime bday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        Console.WriteLine("Your age now: " + (today.Year - bday.Year));
        Console.WriteLine("Your age after 10 years: " + (today.Year - bday.Year + 10));
    }
}