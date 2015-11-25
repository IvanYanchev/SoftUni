using BankOfKurtovoKonare.Intarfaces;
using System;

namespace BankOfKurtovoKonare.Models
{
    public class DepositAccount : Account, IWithdrawable
    {
        private const int MinimumBalanceForInterest = 1000;

        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        // Deposit accounts have no interest if their balance is positive and less than 1000.

        public override decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (1 + (this.InterestRate / 100) * months);

            if (this.Balance <= MinimumBalanceForInterest)
            {
                interest = 0;
            }

            return interest;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("The withdraw amount should be greater than zero!");
            }
            else if (amount > this.Balance)
            {
                throw new ArgumentNullException("The withdraw amount can not exceed the current account balance!");
            }

            this.Balance -= amount;
        }
    }
}
