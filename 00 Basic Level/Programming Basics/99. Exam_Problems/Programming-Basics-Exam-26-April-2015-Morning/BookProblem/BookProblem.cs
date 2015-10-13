using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine()); // the number of pages of the book.
            int campingDays = int.Parse(Console.ReadLine()); // the number of camping days in a month.
            int pagesPerNormalDay = int.Parse(Console.ReadLine()); // the number of pages which Stefan reads every normal day.  

            int normalDays = 30 - campingDays;
            int pagesPerMonth = normalDays * pagesPerNormalDay;
            if (pagesPerMonth <= 0)
            {
                Console.WriteLine("never");
                return;
            }
            int monthsToReadTheWholeBook = bookPages / pagesPerMonth;
            if (bookPages % pagesPerMonth != 0)
            {
                monthsToReadTheWholeBook += 1;
            }

            Console.WriteLine("{0} years {1} months", monthsToReadTheWholeBook / 12, monthsToReadTheWholeBook % 12);
           
        }
    }
}
