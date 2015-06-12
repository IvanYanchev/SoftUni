using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Models
{
    public abstract class Customer
    {
        private string name;
        private long customerID;

        protected Customer(string name, long customerID)
        {
            this.Name = name;
            this.CustomerID = customerID;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The customer's name can not be null or empty.");
                }

                this.name = value;
            }
        }

        public long CustomerID
        {
            get
            {
                return this.customerID;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The customer's ID can not be less or equal to zero.");
                }

                this.customerID = value;
            }
        }
    }
}
