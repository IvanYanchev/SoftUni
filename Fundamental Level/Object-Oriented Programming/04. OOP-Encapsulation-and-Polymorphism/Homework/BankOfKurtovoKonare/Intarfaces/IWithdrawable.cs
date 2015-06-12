using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Intarfaces
{
    public interface IWithdrawable
    {
        void WithdrawMoney(decimal amount);
    }
}
