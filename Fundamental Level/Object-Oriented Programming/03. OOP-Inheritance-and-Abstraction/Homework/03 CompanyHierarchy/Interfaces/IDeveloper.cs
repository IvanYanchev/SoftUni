using CompanyHierarchy.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
        void AddProject(Project project);
    }
}
