using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Learning_System.Persons
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
