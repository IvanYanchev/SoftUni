using System;
using System.Globalization;

    class ExamSchedule
    {
        static void Main()
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            string startPartOfTheDay = Console.ReadLine();
            string startTimeString = startHour +":"+startMinutes+" "+startPartOfTheDay;
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            DateTime startTime = Convert.ToDateTime(startTimeString);
            DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);

            string endTimeString = endTime.ToString("hh:mm:tt", CultureInfo.InvariantCulture);
            Console.WriteLine(endTimeString);
            
        }
    } 