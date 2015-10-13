using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        int p;
        int h;
        int numberOfWeeks;

        Console.Write("Input \"t\" for leap year or \"f\" for year that is not leap: ");
        string leap = Console.ReadLine();
        Console.Write("Input number of holidays in the year (which are not Saturday or Sunday): ");
        p = int.Parse(Console.ReadLine());
        Console.Write("Input number of weekends that Joro spends in his hometown: ");
        h = int.Parse(Console.ReadLine());

        int weeksNotTired = 2 * (52 - h) / 3;
        int weeksHolidays = p / 2;

        if (leap == "t")
        {
            numberOfWeeks = (int)(weeksNotTired + h + weeksHolidays + 3);
            Console.WriteLine(numberOfWeeks);
        }
        else
        {
            numberOfWeeks = (int)(weeksNotTired + h + weeksHolidays);
            Console.WriteLine(numberOfWeeks);
        }
    }
}