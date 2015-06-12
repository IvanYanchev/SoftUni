using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstname, string lastName, string facultyNumber) : base(firstname, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        {
            get { return this.facultyNumber; } 
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faculty number has to be 5..10 symbols long");
                }
                else
                {
                    this.facultyNumber = value;
                }
            } 
        }

        //public override string ToString()
        //{
        //    return base.FirstName + " " + base.LastName;
        //}
    }
}
