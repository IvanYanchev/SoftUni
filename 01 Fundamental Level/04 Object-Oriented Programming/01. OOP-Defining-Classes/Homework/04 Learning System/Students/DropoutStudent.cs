using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Learning_System.Students
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public string DropoutReason { get; set; }

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber) :
            base(firstName, lastName, age, studentNumber)
        {

        }

        private void Reapply()
        {
            Console.WriteLine("Name: {0} {1}", this.FirstName, this.LastName);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("Student number: {0}", this.StudentNumber);
            Console.WriteLine("Average grade: {0}", this.AverageGrade);
            Console.WriteLine("Dropout reason: {0}", this.DropoutReason);
        }
    }
}
