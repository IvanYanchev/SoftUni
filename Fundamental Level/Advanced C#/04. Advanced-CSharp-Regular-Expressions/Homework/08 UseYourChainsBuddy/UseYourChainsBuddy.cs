using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string inputHtml = Console.ReadLine();

            string ptagPattern = @"<p>([^<]+)<\/p>";

            MatchCollection tags = Regex.Matches(inputHtml, ptagPattern);

            foreach (Match match in tags)
            {
                string otherCharactersPattern = @"[^a-z0-9]";
                string strWithOnlySmallLettersAndDigits = Regex.Replace(match.Groups[1].ToString(), otherCharactersPattern, " ");
                //remove multiple whitespaces
                strWithOnlySmallLettersAndDigits = Regex.Replace(strWithOnlySmallLettersAndDigits, @"\s+", " ");

                StringBuilder decodedText = new StringBuilder();
                for (int i = 0; i < strWithOnlySmallLettersAndDigits.Length; i++)
                {
                    char ch = strWithOnlySmallLettersAndDigits[i];
                    char decodedCh = (char)ch;
                    if (ch >= 'a' && ch <= 'm')
                    {
                        decodedCh = (char)(ch + 13);
                    }
                    else if (ch >= 'n' && ch <= 'z')
                    {
                        decodedCh = (char)(ch - 13);
                    }
                    decodedText.Append(decodedCh);
                }
                Console.Write("{0}", decodedText.ToString());
            }
        }
    }
}
