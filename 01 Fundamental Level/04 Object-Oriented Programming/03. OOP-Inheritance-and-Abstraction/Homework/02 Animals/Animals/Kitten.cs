using System;

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
            Console.WriteLine("Murrrrrr");
        }
    }
}
