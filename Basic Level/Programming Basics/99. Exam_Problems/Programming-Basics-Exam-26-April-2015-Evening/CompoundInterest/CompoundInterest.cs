using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            double p = double.Parse(Console.ReadLine()); // price of the TV.
            int n = int.Parse(Console.ReadLine());  // number of years you have until you must pay the bank back (term).
            double i = double.Parse(Console.ReadLine());  // the yearly interest rate for the bank’s loan.
            double f = double.Parse(Console.ReadLine());  // interest rate for your friend’s loan.

            string lender = "Bank";
            double bankLoan = p * Math.Pow((1.0 + i), n);
            double friendLoan = p * (1.0 + f);
            if (bankLoan > friendLoan) lender = "Friend";

            Console.WriteLine("{0:0.00} {1}", Math.Min(bankLoan,friendLoan), lender);
        }
    }
}
