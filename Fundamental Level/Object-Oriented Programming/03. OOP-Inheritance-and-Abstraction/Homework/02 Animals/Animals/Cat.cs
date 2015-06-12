using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, string gender): base(name, age, gender)
        {

        }
    }
}
