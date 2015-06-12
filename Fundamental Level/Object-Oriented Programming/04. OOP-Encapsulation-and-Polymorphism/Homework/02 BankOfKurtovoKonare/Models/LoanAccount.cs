using BankOfKurtovoKonare.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Models
{
    public class LoanAccount : Account
    {
        private const int GratisPeriodForIndividuals = 3;
        private const int GratisPeriodForCompanies = 2;

        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        // Loan accounts have no interest for the first 3 months if held by individuals and for the first 2 months if held by a company.

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;

            if (this.Customer is IndividualCustomer && months > GratisPeriodForIndividuals) 
            {
                interest = this.Balance * (1 + (this.InterestRate / 100) * (months - GratisPeriodForIndividuals));
            }
            else if (this.Customer is CompanyCustomer && months > GratisPeriodForCompanies)
            {
                interest = this.Balance * (1 + (this.InterestRate / 100) * (months - GratisPeriodForCompanies));
            }

            return interest;
        }
    }
}
