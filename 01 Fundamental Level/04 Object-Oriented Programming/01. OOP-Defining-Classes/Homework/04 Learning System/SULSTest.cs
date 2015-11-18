using _04_Learning_System.Persons;
using _04_Learning_System.Trainers;
using _04_Learning_System.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            JuniorTrainer jt = new JuniorTrainer("Ivan", "Ivanov", 23);
            SeniorTrainer st = new SeniorTrainer("Georgi", "Georgiev", 29);
            DropoutStudent ds = new DropoutStudent("Stamat", "Petkov", 27, 11328);
            OnsiteStudent oss = new OnsiteStudent("Dimitar", "Dimitrov", 19, 14952, "OOP");
            oss.AverageGrade = 5.25;
            OnlineStudent ols = new OnlineStudent("Apostol", "Karadimchev", 37, 12039, "OOP");
            ols.AverageGrade = 4.75;
            GraduateStudent gs = new GraduateStudent("Milko", "Abadzhiev", 32, 9802);

            List<Person> list = new List<Person>()
            {
                jt,
                st,
                ds,
                oss,
                ols,
                gs,
            };

            var currentStuents = list.OfType<CurrentStudent>().Select(x => (CurrentStudent)x).OrderBy(x => x.AverageGrade);

            foreach (var student in currentStuents)
            {
                Console.WriteLine("Student: {0} {1}, Age: {2}, StudentNumber: {3}, AverageGrade: {4}", student.FirstName, student.LastName, student.Age, student.StudentNumber, student.AverageGrade);
            }
        }
    }
}
