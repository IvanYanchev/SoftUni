﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        int Salary { get; set; }
        Department Department { get; set; }
    }
}
