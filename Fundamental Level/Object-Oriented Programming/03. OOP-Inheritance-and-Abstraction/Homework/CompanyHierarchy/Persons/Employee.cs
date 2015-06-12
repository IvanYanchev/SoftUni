using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public abstract class Employee : Person, IEmployee
    {
        private int salary;
        private Department department;

        protected Employee(long id, string firstName, string lastName, int salary, Department dep)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = dep;
        }

        public int Salary 
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Department Department 
        {
            get { return this.department; }
            set { this.department = value; }
        }
    }
}
