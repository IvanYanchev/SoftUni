using System;

namespace Problem_2.Interest_Calculator
{
    public delegate double CalculateInterest(double sum, double interest, int years);

    public class InterestCalculator
    {
        public InterestCalculator(decimal sum, decimal interest, int years, Func<decimal, decimal, int, decimal> interestCalculator)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.Calculator = interestCalculator(sum, interest, years);
        }

        public decimal Sum { get; set; }

        public decimal Interest { get; set; }

        public int Years { get; set; }

        public decimal Calculator { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Money = {0}\nInterest = {1}\nYears = {2}\nTotalSum = {3:F4}\n",
                this.Sum, 
                this.Interest, 
                this.Years, 
                this.Calculator);
        }
    }
}