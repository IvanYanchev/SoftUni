using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class NewProgramUsingClassPerson
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
