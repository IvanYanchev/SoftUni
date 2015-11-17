using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Learning_System.Trainers
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) : 
            base(firstName, lastName, age)
        {

        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} course has been deleted", courseName);
        }
    }
}
