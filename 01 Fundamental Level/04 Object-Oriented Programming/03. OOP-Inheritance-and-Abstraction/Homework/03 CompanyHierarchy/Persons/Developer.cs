using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Structs;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects = new List<Project>();

        public Developer(long id, string firstName, string lastName, int salary, Department dep, params Project[] projects)
            : base(id, firstName, lastName, salary, dep)
        {
            this.Projects = projects.ToList();
        }

        public List<Project> Projects { get; set; }

        public void AddProject(Project project)
        {
            this.Projects.Add(project);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("Developer: {0} {1}, Department: {2}, Salary: {3}, Projects:\r\n", base.FirstName, base.LastName, base.Department, base.Salary));
            foreach (var project in this.Projects)
            {
                output.Append(project);
            }
            return output.ToString();
        }
    }
}
