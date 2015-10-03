using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace _11_Students_by_Groups
{
    class StudentsByGroups
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>()
            {
                new Student( "Ivan",    "Ivanov", 19, 165814, "0897698456", "iivanov@yahoo.com", new List<int>{5,   4,  5,  6, }, 1, "Nerds"),
                new Student( "Ivan",    "Angelov", 40, 163215, "0878 79 94 66", "ivan.angelov@gmail.com", new List<int>{2,  2,  4,  4, }, 2, "Cool Guys"),
                new Student( "Petar",   "Georgiev", 29, 125813, "0888 888 621", "p.georgiev@mail.bg", new List<int>{3,  4,  5,  6, }, 1, "Nerds"),
                new Student( "Ivelin",  "Dimitrov", 26, 136814, "0899548123",   "ivelin.dimitrov@gmail.com", new List<int>{5,   5, }, 2, "Cool Guys"),
                new Student( "Sara",    "Velikova", 22, 198612, "+3592 945 14 51",  "sarrrrrra@outlook.com", new List<int>{3,   4,  3,  4, }, 3, "Fitness Maniacs"),
                new Student( "Marieta", "Nikolova", 34, 112313, "0898 320 320", "marietka@abv.bg", new List<int>{2, 2,  2,  3, }, 3, "Fitness Maniacs"),
                new Student( "Marieta", "Kirilova", 24, 184313, "0888000555",   "kirilova@bitex.com", new List<int>{3,  4,  5, }, 2, "Cool Guys"),
                new Student( "Georgi",  "Milanov", 30, 195614, "+359 2 992 11 02",  "gmilanov@yahoo.com", new List<int>{6,  6,  6,  6, }, 1, "Nerds"),
                new Student( "Stamat",  "Penkov", 21, 163112, "0888 11 22 33",  "stamat_penkov@mail.com", new List<int>{2,  4,  5,  4, }, 2, "Cool Guys"),
                new Student( "Ferdinand",   "Katarov", 45, 114812, "0899980182",    "ferdinand2001@abv.bg", new List<int>{3,    5,  5,  3, }, 3, "Fitness Maniacs"),
                new Student( "Elizabeth",   "Grigorova", 28, 141614, "056885521",   "eli_grigorova@gmail.com", new List<int>{5, 6,  5,  4, }, 2, "Cool Guys"),
                new Student( "Yanko",   "Mitov", 20, 154914, "0888 14 78 54",   "yankopolkovnika@abv.bg", new List<int>{2,  3,  3,  5, }, 2, "Cool Guys"),
                new Student( "Antoaneta",   "Parvanova", 37, 171815, "029597431",   "aztrifonova@minedu.government.bg", new List<int>{6, 6, 5,  6, }, 1, "Nerds"),

            };

            //Problem 11.	* Students by Groups
            //Add a GroupName property to Student.
            //Write a program that extracts all students grouped by GroupName and then prints them on the console.
            //Print all group names along with the students in each group. Use the "group by into" LINQ operator.

            var studentsByGroupName =
                from student in listOfStudents
                group student by student.GroupName into groups
                select groups;

            foreach (var group in studentsByGroupName)
            {
                Console.WriteLine("Group \"{0}\" :", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Student: {0,9} {1,9}", student.FirstName, student.LastName);
                }
                Console.WriteLine();
            }
        }
    }
}
