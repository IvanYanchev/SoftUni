﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Learning_System.Students
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits = 0;

        public int NumberOfVisits { get; set; }

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, string currentCourse) :
            base(firstName, lastName, age, studentNumber, currentCourse)
        {

        }
    }
}
