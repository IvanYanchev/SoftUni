using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons
{
    public abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(long id, string firstName, string lastName, int salary, Department dep)
            : base(id, firstName, lastName, salary, dep)
        {

        }
    }
}
