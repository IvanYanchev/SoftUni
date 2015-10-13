using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "f")
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Murrrrrr"); ;
        }
    }
}
