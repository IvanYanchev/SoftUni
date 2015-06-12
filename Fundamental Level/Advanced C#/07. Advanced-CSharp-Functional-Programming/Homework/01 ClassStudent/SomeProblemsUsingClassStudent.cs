using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class SomeProblemsUsingClassStudent
    {
        static void Main()
        {
            //Problem 1.	Class Student
            //Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber.
            //Create a List<Student> with sample students. These students will be used for the next few tasks.

            var listOfStudents = new List<Student>()
            {
                new Student( "Ivan",	"Ivanov", 19, 165814, "0897698456",	"iivanov@yahoo.com", new List<int>{5,	4,	5,	6, }, 1, "Nerds"),
                new Student( "Ivan",	"Angelov", 40, 163215, "0878 79 94 66",	"ivan.angelov@gmail.com", new List<int>{2,	2,	4,	4, }, 2, "Cool Guys"),
                new Student( "Petar",	"Georgiev", 29, 125813, "0888 888 621",	"p.georgiev@mail.bg", new List<int>{3,	4,	5,	6, }, 1, "Nerds"),
                new Student( "Ivelin",	"Dimitrov", 26, 136814, "0899548123",	"ivelin.dimitrov@gmail.com", new List<int>{5,	5, }, 2, "Cool Guys"),
                new Student( "Sara",	"Velikova", 22, 198612, "+3592 945 14 51",	"sarrrrrra@outlook.com", new List<int>{3,	4,	3,	4, }, 3, "Fitness Maniacs"),
                new Student( "Marieta",	"Nikolova", 34, 112313, "0898 320 320",	"marietka@abv.bg", new List<int>{2,	2,	2,	3, }, 3, "Fitness Maniacs"),
                new Student( "Marieta",	"Kirilova", 24, 184313, "0888000555",	"kirilova@bitex.com", new List<int>{3,	4,	5, }, 2, "Cool Guys"),
                new Student( "Georgi",	"Milanov", 30, 195614, "+359 2 992 11 02",	"gmilanov@yahoo.com", new List<int>{6,	6,	6,	6, }, 1, "Nerds"),
                new Student( "Stamat",	"Penkov", 21, 163112, "0888 11 22 33",	"stamat_penkov@mail.com", new List<int>{2,	4,	5,	4, }, 2, "Cool Guys"),
                new Student( "Ferdinand",	"Katarov", 45, 114812, "0899980182",	"ferdinand2001@abv.bg", new List<int>{3,	5,	5,	3, }, 3, "Fitness Maniacs"),
                new Student( "Elizabeth",	"Grigorova", 28, 141614, "056885521",	"eli_grigorova@gmail.com", new List<int>{5,	6,	5,	4, }, 2, "Cool Guys"),
                new Student( "Yanko",	"Mitov", 20, 154914, "0888 14 78 54",	"yankopolkovnika@abv.bg", new List<int>{2,	3,	3,	5, }, 2, "Cool Guys"),
                new Student( "Antoaneta",	"Parvanova", 37, 171815, "029597431",	"aztrifonova@minedu.government.bg", new List<int>{6, 6,	5,	6, }, 1, "Nerds"),

            };

            //Problem 2.	Students by Group
            //Print all students from group number 2. Use a LINQ query. Order the students by FirstName.

            int groupNumber = 2;
            var studentsByGroupNumber =
                from student in listOfStudents
                where student.GroupNumber == groupNumber
                orderby student.FirstName
                select student;

            Console.WriteLine("List of all students from group number {0}:", groupNumber);
            foreach (var student in studentsByGroupNumber)
            {
                Console.WriteLine("Student: {0,9} {1,9}, Group number: {2}", student.FirstName, student.LastName, student.GroupNumber);
            }

            //Problem 3.	Students by First and Last Name
            //Print all students whose first name is before their last name alphabetically. Use a LINQ query.

            var studentsByFirstandLastName =
                from student in listOfStudents
                where (student.FirstName).CompareTo(student.LastName) < 0
                select student;
            Console.WriteLine();
            Console.WriteLine("List of all students whose first name is before their last name alphabetically:");
            foreach (var student in studentsByFirstandLastName)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //Problem 4.	Students by Age
            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            //The query should return only the first name, last name and age.

            var studentsByAge =
                from student in listOfStudents
                where student.Age >= 18 && student.Age <= 24
                select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };
            Console.WriteLine();
            Console.WriteLine("List all of students with age between 18 and 24:");
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("{0} {1}, Age: {2}", student.FirstName, student.LastName, student.Age);
            }

            //Problem 5.	Sort Students
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
            //Rewrite the same with LINQ query syntax.

            var sortedListOfStudents =
                listOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine();
            Console.WriteLine("List of students sorted by first name and last name in descending order (using lambda expression):");
            foreach (var student in sortedListOfStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            sortedListOfStudents =
                from student in listOfStudents
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine();
            Console.WriteLine("List of students sorted by first name and last name in descending order (using LINQ query syntax):");
            foreach (var student in sortedListOfStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //Problem 6.	Filter Students by Email Domain
            //Print all students that have email @abv.bg. Use LINQ.

            var studentsByEmailDomain =
                from student in listOfStudents
                where student.Email.Contains("@abv.bg")
                select student;
            Console.WriteLine();
            Console.WriteLine("List of all students that have email @abv.bg :");
            foreach (var student in studentsByEmailDomain)
            {
                Console.WriteLine("{0} {1}, Email: {2}", student.FirstName, student.LastName, student.Email);
            }

            //Problem 7.	Filter Students by Phone
            //Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.

            var studentsByPhone =
                from student in listOfStudents
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;
            Console.WriteLine();
            Console.WriteLine("List of all students with phones in Sofia (starting with 02 / +3592 / +359 2) :");
            foreach (var student in studentsByPhone)
            {
                Console.WriteLine("{0} {1}, Phone: {2}", student.FirstName, student.LastName, student.Phone);
            }

            //Problem 8.	Excellent Students
            //Print all students that have at least one mark Excellent (6).
            //Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.

            var excellentStudents =
                from student in listOfStudents
                where student.Marks.Contains(6)
                select new { FullName = string.Join(" ", student.FirstName, student.LastName), Marks = student.Marks };
            Console.WriteLine();
            Console.WriteLine("List of all students that have at least one mark Excellent (6) :");
            foreach (var student in excellentStudents)
            {
                Console.WriteLine("{0}, Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }

            //Problem 9.	Weak Students
            //Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.

            var weakStudents =
                from student in listOfStudents
                where student.Marks.Count(x => x == 2) == 2
                select new { FullName = string.Join(" ", student.FirstName, student.LastName), Marks = student.Marks };
            Console.WriteLine();
            Console.WriteLine("List of all students with exactly two marks \"2\" :");
            foreach (var student in weakStudents)
            {
                Console.WriteLine("{0}, Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }

            //Problem 10.	Students Enrolled in 2014
            //Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).

            var studentsEnrolledIn2014 =
                listOfStudents.FindAll(x => x.FacultyNumber % 100 == 14);
            Console.WriteLine();
            Console.WriteLine("Marks of the students that enrolled in 2014:");
            foreach (var student in studentsEnrolledIn2014)
            {
                Console.WriteLine("{0} {1}, FacultyNumber: {2}, Marks: {3}", student.FirstName, student.LastName, student.FacultyNumber, string.Join(", ", student.Marks));
            }

            //Problem 11.	* Students by Groups
            //Add a GroupName property to Student.
            //Write a program that extracts all students grouped by GroupName and then prints them on the console.
            //Print all group names along with the students in each group. Use the "group by into" LINQ operator.

            var studentsByGroupName =
                from student in listOfStudents
                group student by student.GroupName into groups
                select groups;
            Console.WriteLine();
            foreach (var group in studentsByGroupName)
            {
                Console.WriteLine("Group \"{0}\" :", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("Student: {0,9} {1,9}", student.FirstName, student.LastName);
                }
            }

            //Problem 12.	* Students Joined to Specialties
            //Create a class StudentSpecialty that holds specialty name and faculty number.
            //Create a list of student specialties, where each specialty corresponds to a certain student (via the faculty number).
            //Print all student names alphabetically along with their faculty number and specialty name. Use the "join" LINQ operator. Example:

            var listOfSpecialtiesByFacultyNumber = new List<StudentSpecialty>()
            {
                new StudentSpecialty( "Web Developer", 165814),
                new StudentSpecialty( "Web Developer", 163215),
                new StudentSpecialty( "PHP Developer", 125813),
                new StudentSpecialty( "Web Developer", 136814),
                new StudentSpecialty( "Web Developer", 198612),
                new StudentSpecialty( "PHP Developer", 112313),
                new StudentSpecialty( "QA Engineer", 184313),
                new StudentSpecialty( "Web Developer", 195614),
                new StudentSpecialty( "QA Engineer", 163112),
                new StudentSpecialty( "PHP Developer", 114812),
                new StudentSpecialty( "Web Developer", 141614),
                new StudentSpecialty( "QA Engineer", 154914),
                new StudentSpecialty( "PHP Developer", 171815),
            };

            var studentsJoinedToSpecialties =
                from specialty in listOfSpecialtiesByFacultyNumber
                join student in listOfStudents on specialty.FacultyNumber equals student.FacultyNumber
                orderby student.FirstName, student.LastName
                select new { FirstName = student.FirstName, LastName = student.LastName, FacultyNum = student.FacultyNumber, Specialty = specialty.SpecialtyName };
            Console.WriteLine();
            Console.WriteLine("Alphabetical list of all students along with their faculty number and specialty name:");
            foreach (var student in studentsJoinedToSpecialties)
            {
                Console.WriteLine("Student: {0,9} {1,9}, Faculty Number: {2,6}, Specialty: {3,10}", student.FirstName, student.LastName, student.FacultyNum, student.Specialty);
            }
        }
    }
}
