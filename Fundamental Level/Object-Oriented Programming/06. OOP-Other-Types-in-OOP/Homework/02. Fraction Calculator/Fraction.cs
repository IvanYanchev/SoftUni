using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fraction_Calculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator 
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator can not be zero.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator+(Fraction fract1, Fraction fract2)
        {
            Fraction result = new Fraction();

            result.numerator = fract1.numerator * fract2.denominator + fract2.numerator * fract1.denominator;
            result.denominator = fract1.denominator * fract2.denominator;

            return result;
        }

        public static Fraction operator-(Fraction fract1, Fraction fract2)
        {
            Fraction result = new Fraction();

            result.numerator = fract1.numerator * fract2.denominator - fract2.numerator * fract1.denominator;
            result.denominator = fract1.denominator * fract2.denominator;

            return result;
        }

        public override string ToString()
        {
            return ((decimal)this.numerator / (decimal)this.denominator).ToString();
        }
    }
}
