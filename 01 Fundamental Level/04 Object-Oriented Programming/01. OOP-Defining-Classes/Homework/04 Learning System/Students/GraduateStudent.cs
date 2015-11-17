using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Learning_System.Students
{
    public class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, int studentNumber) :
            base(firstName, lastName, age, studentNumber)
        {
                
        }
    }
}
