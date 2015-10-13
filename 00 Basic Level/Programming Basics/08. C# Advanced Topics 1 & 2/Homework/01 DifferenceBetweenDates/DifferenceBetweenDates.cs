using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Please enter start date in format dd.MM.yyyy : ");
        string startDateString = Console.ReadLine();
        Console.Write("Please enter end date in format dd.MM.yyyy : ");
        string endDateString = Console.ReadLine();
        DateTime startDate = Convert.ToDateTime(startDateString);
        DateTime endDate = Convert.ToDateTime(endDateString);

        Console.WriteLine("There are {0} days between them.", (endDate - startDate).Days);
    }
}