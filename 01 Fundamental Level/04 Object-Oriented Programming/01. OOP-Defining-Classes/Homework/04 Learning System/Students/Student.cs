using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Learning_System.Persons;

namespace _04_Learning_System.Students
{
    public abstract class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        public int StudentNumber { get; set; }
        public double AverageGrade { get; set; }

        protected Student(string firstName, string lastName, int age, int studentNumber) : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
        }
    }
}
