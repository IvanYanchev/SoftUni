using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Learning_System.Persons;

namespace _04_Learning_System.Students
{
    public abstract class CurrentStudent : Student
    {
        private string currentCourse;

        public string CurrentCourse { get; set; }

        protected CurrentStudent(string firstName, string lastName, int age, int studentNumber, string currentCourse) : 
            base(firstName, lastName, age, studentNumber)
        {
            this.CurrentCourse = currentCourse;
        }
    }
}
