using CompanyHierarchy.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IManager
    {
        List<Employee> Subordinates { get; set; }
    }
}
