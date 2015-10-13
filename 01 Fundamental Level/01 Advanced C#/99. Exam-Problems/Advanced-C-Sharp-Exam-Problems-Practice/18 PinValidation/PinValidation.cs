using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinValidation
{
    class PinValidation
    {
        static void Main(string[] args)
        {
            string fullName = Console.ReadLine();
            string gender = Console.ReadLine();
            long pin = long.Parse(Console.ReadLine());

            long checksum = pin % 10;
            string pinString = pin.ToString();
            if (pinString.Length < 10)
            {
                pinString = new string('0', 10 - pinString.Length) + pinString;
            }

            var d = pinString.Select(x => int.Parse(x.ToString())).ToArray();

            int sum = d[0]*2 + d[1]*4 + d[2]*8 + d[3]*5 + d[4]*10 + d[5]*9 + d[6]*7 + d[7]*3 + d[8]*6;
            int remainder = sum % 11 == 10 ? 0 : sum % 11;

            string[] twoNames = fullName.Split(' ');


            string output = string.Format("{{\"name\":\"{0}\",\"gender\":\"{1}\",\"pin\":\"{2}\"}}", fullName, gender, pinString);

            if ((remainder != checksum) ||
                ((gender == "male" && d[8] % 2 != 0) || (gender == "female" && d[8] % 2 != 1)) ||
                (twoNames.Length != 2 || !char.IsUpper(twoNames[0][0]) || !char.IsUpper(twoNames[1][0])) ||
                ((d[2] * 10 + d[3]) > 52) || ((d[4] * 10 + d[5]) > 31))
            {
                output = "<h2>Incorrect data</h2>";
            }
            
            Console.WriteLine(output);
        }
    }
}
