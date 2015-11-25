using System;

namespace Animals.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "m")
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myauuuuu");
        }
    }
}
