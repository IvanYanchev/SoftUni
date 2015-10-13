using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithAbstraction.Characters;

namespace WorkingWithAbstraction
{
    class WorkingWithAbstraction
    {
        static void Main(string[] args)
        {
            Warrior conanTheBarberian = new Warrior();
            Warrior hercules = new Warrior();

            Mage gandalf = new Mage();

            Priest pr = new Priest();
            Console.WriteLine("Round 0:\r\n");
            Console.WriteLine(conanTheBarberian);
            Console.WriteLine(gandalf);
            Console.WriteLine(pr);

            conanTheBarberian.Attack(gandalf);
            pr.Heal(gandalf);
            pr.Attack(conanTheBarberian);
            Console.WriteLine("Round 1:\r\n");
            Console.WriteLine(conanTheBarberian);
            Console.WriteLine(gandalf);
            Console.WriteLine(pr);
        }
    }
}
