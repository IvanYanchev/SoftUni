﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace _05_Sort_Students
{
    class SortStudents
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

            //Problem 5.	Sort Students
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
            //Rewrite the same with LINQ query syntax.

            var sortedListOfStudents =
                listOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

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
        }
    }
}
