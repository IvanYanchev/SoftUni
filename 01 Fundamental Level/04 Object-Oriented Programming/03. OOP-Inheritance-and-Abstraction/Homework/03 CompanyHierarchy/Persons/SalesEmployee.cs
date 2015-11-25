using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Structs;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales = new List<Sale>();

        public SalesEmployee(long id, string firstName, string lastName, int salary, Department dep, params Sale[] sales) 
            : base(id, firstName, lastName, salary, dep)
        {
            this.Sales = sales.ToList();
        }

        public List<Sale> Sales { get; set; }

        public void AddSale(Sale sale)
        {
            this.sales.Add(sale);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("Seller: {0} {1}, Department: {2}, Salary: {3}, Sales:\r\n", base.FirstName, base.LastName, base.Department, base.Salary));
            foreach (var sale in this.Sales)
            {
                output.Append(sale);
            }
            return output.ToString();
        }
    }
}
