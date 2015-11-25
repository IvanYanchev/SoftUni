using System;
using System.Linq;

namespace HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstname, string lastName, string facultyNumber) 
            : base(firstname, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        {
            get { return this.facultyNumber; } 
            set
            {
                if (value.Length < 5 || value.Length > 10 || value.Any(c => !char.IsLetterOrDigit(c)))
                {
                    throw new ArgumentException("Faculty number has to be 5-10 digits / letters");
                }
                else
                {
                    this.facultyNumber = value;
                }
            } 
        }
    }
}
