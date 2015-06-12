using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "search")
                {
                    break;
                }
                string[] splittedInputString = inputString.Split('-');
                if (phonebook.ContainsKey(splittedInputString[0]))
                {
                    phonebook[splittedInputString[0]] += ", " + splittedInputString[1];
                }
                else
                {
                    phonebook.Add(splittedInputString[0], splittedInputString[1]);
                }
            }
            while (true)
            {
                string searchKey = Console.ReadLine();
                if (phonebook.ContainsKey(searchKey))
                {
                    Console.WriteLine("{0} --> {1}", searchKey, phonebook[searchKey]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", searchKey);
                }
            }
        }
    }
}
