using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Models
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name, long id)
            : base(name, id)
        {

        }
    }
}
