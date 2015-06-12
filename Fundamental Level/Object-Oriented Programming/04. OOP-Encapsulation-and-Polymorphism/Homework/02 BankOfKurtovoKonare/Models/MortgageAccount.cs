using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Intarfaces;

namespace BankOfKurtovoKonare.Models
{
    public class MortgageAccount : Account
    {
        private const int GratisPeriodForIndividuals = 6;
        private const int PromoPeriodForCompanies = 12;
        private const decimal PromoInterestForCompanies = 0.5M;

        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        // Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0; ;

            if (this.Customer is IndividualCustomer && months > GratisPeriodForIndividuals)
            {
                interest = this.Balance * (1 + (this.InterestRate / 100) * (months - GratisPeriodForIndividuals));
            }
            else if (this.Customer is CompanyCustomer && months <= PromoPeriodForCompanies)
            {
                interest = this.Balance * (1 + (this.InterestRate / 100) * PromoInterestForCompanies * months);
            }
            else if (this.Customer is CompanyCustomer && months > PromoPeriodForCompanies)
            {
                interest = this.Balance * (1 + (this.InterestRate / 100) * PromoInterestForCompanies * PromoPeriodForCompanies) + this.Balance * (1 + (this.InterestRate / 100) * (months - PromoPeriodForCompanies));                
            }

            return interest;
        }
    }
}
