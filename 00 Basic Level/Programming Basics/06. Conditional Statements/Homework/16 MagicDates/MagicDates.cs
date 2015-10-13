using System;

    class MagicDates
    {
        static void Main()
        {
            int startYear = int.Parse(Console.ReadLine()); // Input data
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());

            DateTime startDate = new DateTime(startYear, 1, 1); //initzialize start and end date
            DateTime endDate = new DateTime(endYear, 12, 31);
            bool isNotFoundMagicDate = true;

            for (DateTime day = startDate; day < endDate; day = day.AddDays(1)) //date cycle
            {
                string dateToString = day.ToString("ddMMyyyy");
                int dateToInt = int.Parse(dateToString);

                int[] digits = new int[8];
                digits[7] = (dateToInt % 10) / 1;
                digits[6] = (dateToInt % 100) / 10;
                digits[5] = (dateToInt % 1000) / 100;
                digits[4] = (dateToInt % 10000) / 1000;
                digits[3] = (dateToInt % 100000) / 10000;
                digits[2] = (dateToInt % 1000000) / 100000;
                digits[1] = (dateToInt % 10000000) / 1000000;
                digits[0] = (dateToInt % 100000000) / 10000000;
                
                int weight = 0;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = i + 1; j < 8; j++)
                    {
                        weight = weight + digits[i] * digits[j];
                    }
                }

                if (weight == magicWeight)
                {
                    dateToString = day.ToString("dd-MM-yyyy");
                    Console.WriteLine(dateToString);
                    isNotFoundMagicDate = false;
                }
            }

            if (isNotFoundMagicDate) Console.WriteLine("No");
        }
    }