using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public class Manager : Employee, IManager
    {
        private List<Employee> subordinates;

        public Manager(long id, string firstName, string lastName, int salary, Department dep, params Employee[] subordinates)
            : base(id, firstName, lastName, salary, dep)
        {
            this.Subordinates = subordinates.ToList();
        }

        public List<Employee> Subordinates
        {
            get { return this.subordinates; }
            set { this.subordinates = value; }
        }

        public override string ToString()
        {
            string output = string.Format("Manager: {0} {1}, Department: {2}, Subordinates: {3}",
                base.FirstName, base.LastName, base.Department, string.Join(", ", this.subordinates.Select(x => x.FirstName)));
            return output;
        }
    }
}
