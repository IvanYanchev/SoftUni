//You are given a string, holding ASCII characters. Find all name -> phone number pairs, format them and print them in an ordered list as list items.
//The name should be at least one letter long, can contain only letters and should always start with an uppercase letter.
//The phone number should be at least two digits long, should start and end with a digit (might also start with “+”) and might contain the following symbols in it: “(“, “)”, “/”, “.”, “-”, “ “ (left and right bracket, slash, dot, dash and whitespace).
//Between a name and the phone number there might be any number of symbols, other than letters and “+”.
//Between the name -> phone number pairs there might be any number of ASCII symbols. 
//The output format should be <b>[name]:</b> [phone number] (there is one space between the name and the phone number). Clear any characters other than digits and “+” from the number when printing the output.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneNumbers
{
    class PhoneNumbers
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string inputString = string.Empty;
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                else
                {
                    inputString += " " + inputLine;
                }
            }

            string pairPattern = @"([A-Z][A-Za-z]*)[^A-Za-z\d\+]*(\+?\d[ \.\d\/()\-]*\d)";
            MatchCollection pairs = Regex.Matches(inputString, pairPattern);
            foreach (Match pair in pairs)
            {
                string name = pair.Groups[1].Value;
                string phonenumber = pair.Groups[2].Value;
                phonenumber = Regex.Replace(phonenumber, @"[^\+\d]", "");
                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phonenumber);
                }
            }

            if (phonebook.Count == 0)
            {
                Console.WriteLine("<p>No matches!</p>");
            }
            else
            {
                Console.Write("<ol>");
                foreach (var entry in phonebook)
                {
                    Console.Write("<li><b>{0}:</b> {1}</li>", entry.Key, entry.Value);
                }
                Console.WriteLine("</ol>");
            }
        }
    }
}
