using BankOfKurtovoKonare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            Customer indiv1 = new IndividualCustomer("Ivan Ivanov", 9786478787874);
            Customer indiv2 = new IndividualCustomer("Georgi Georgiev", 394854398348);
            Customer comp = new CompanyCustomer("ET Dai Var", 3984573498);

            DepositAccount acc1 = new DepositAccount(indiv1, 980, 0.05M);
            Account acc2 = new LoanAccount(comp, 15000, 0.25M);
            Account acc3 = new MortgageAccount(indiv2, 65000, 0.15M);

            Console.WriteLine(acc1.CalculateInterest(6)); 
            acc1.DepositMoney(250);
            acc1.WithdrawMoney(150);
            Console.WriteLine(acc1.CalculateInterest(16));

            Console.WriteLine(acc2.CalculateInterest(18));

            Console.WriteLine(acc3.CalculateInterest(24));
        }
    }
}
