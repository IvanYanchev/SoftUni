using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SemanticHTML
{
    class SemanticHTML
    {
        static void Main(string[] args)
        {
            List<string> allowedTags = new List<string>() { "main", "header", "nav", "article", "section", "aside", "footer" };

            while (true)
            {
                string inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }

                //check if the input text is a line with ref start
                string refPatternStart = @"<div[^>]+>";
                Match matchRefStart = Regex.Match(inputText, refPatternStart);
                string outputText = inputText;

                if (matchRefStart.Success)
                {
                    string tagPattern = @"(id|class)\s?=\s?""(\w+)""";
                    Match matchTag = Regex.Match(matchRefStart.Value, tagPattern);

                    if (allowedTags.Contains(matchTag.Groups[1].Value))
                    {
                        outputText = Regex.Replace(inputText, "div", matchTag.Groups[1].Value);
                        outputText = Regex.Replace(outputText, matchTag.Value, "");
                    }
                    // remove multiple whitespaces
                    string multipleSpacesPattern = @"\S(\s{2,})[^>\s]";
                    MatchCollection matchedSpaces = Regex.Matches(outputText, multipleSpacesPattern);
                    foreach (Match match in matchedSpaces)
                    {
                        outputText = Regex.Replace(outputText, match.Groups[1].Value, " ");
                    }
                    // remove whitespaces at the end
                    string spacesAtEndPattern = @"\S(\s+>)";
                    Match spacesAtEnd = Regex.Match(outputText, spacesAtEndPattern);
                    if (spacesAtEnd.Success)
                    {
                        outputText = Regex.Replace(outputText, spacesAtEnd.Groups[1].Value, ">");
                    }
                }

                // check if the input text is line with ref end
                string refPatternEnd = @"<\/div>([^\w]+(\w+)[^\w]+)";
                Match matchTagEnd = Regex.Match(inputText, refPatternEnd);
                if (matchTagEnd.Success && allowedTags.Contains(matchTagEnd.Groups[2].Value))
                {
                    outputText = Regex.Replace(inputText, "div", matchTagEnd.Groups[2].Value);
                    outputText = Regex.Replace(outputText, matchTagEnd.Groups[1].Value, "");
                }

                Console.WriteLine(outputText);
            }
        }
    }
}
