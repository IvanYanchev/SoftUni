using System;

    class BeerTime
    {
        static void Main()
        {
            Console.Write("Please enter a time in format \"hh:mm tt\": ");
            string input = Console.ReadLine();
            DateTime beerTime;
            DateTime beerTimeStart = DateTime.Parse("01:00 PM");
            DateTime beerTimeEnd = DateTime.Parse("03:00 AM");

            bool isValidTime = DateTime.TryParse(input, out beerTime);

            if (isValidTime)
            {
                if (beerTime >= beerTimeStart || beerTime < beerTimeEnd)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }