using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
    class Program
    {
        static void Main()
        {
            Person firstPerson = new Person("Ivan Ivanov", 28);
            Person secondPerson = new Person("Stoyan Petrov", 28, "spetrov@mail.bg");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
