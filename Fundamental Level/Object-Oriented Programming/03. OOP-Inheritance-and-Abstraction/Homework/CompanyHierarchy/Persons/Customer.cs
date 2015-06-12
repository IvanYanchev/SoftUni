using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons
{
    public class Customer : Person, ICustomer
    {
        private double netPurchaseAmount = 0;

        public Customer(long id, string firstName, string lastName) : base(id, firstName, lastName)
        {

        }

        public double NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
        }

        public void AddPurchaseAmount(double amaunt)
        {
            this.netPurchaseAmount += amaunt;
        }

        public override string ToString()
        {
            string output = string.Format("Customer: {0} {1}, NetPurchaseAmount: {2}", base.FirstName, base.LastName, this.NetPurchaseAmount);
            return output;
        }
    }
}
