﻿using System;
using System.Collections.Generic;

// Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber.

namespace ClassStudent
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, List<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }
    }
}
