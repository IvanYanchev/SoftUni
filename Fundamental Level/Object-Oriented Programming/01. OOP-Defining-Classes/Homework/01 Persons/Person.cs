using System;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new NullReferenceException("Invalid name.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid age.");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentOutOfRangeException("Invalid email.");
                }
                this.email = value;
            }
        }

        public Person(string name, int age, string email = null)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Email: {2}", this.Name, this.Age, this.Email);
        }
    }
}


