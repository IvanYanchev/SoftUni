using Animals.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class PlayWithAnimals
    {
        static void Main()
        {
            List<Animal> myAnimals = new List<Animal>()
            {
                new Dog("Sharo", 5, "m"),
                new Dog("Hera", 7, "f"),
                new Dog("Topcho", 1, "m"),
                new Dog("Vihar", 10, "m"),
                new Tomcat("Leopold", 4),
                new Kitten("Isabella", 3),
                new Tomcat("Garfield", 5),
                new Frog("Kermit", 1, "m"),
                new Frog("Mr.Toad", 2, "m"),
            };

            foreach (var kind in myAnimals.GroupBy(x => x.GetType().Name))
            {
                double averageAge = kind.Select(x => x.Age).Average();

                Console.WriteLine("Animal : {0}, AverageAge: {1}", kind.Key, averageAge);
            }
        }
    }
}
