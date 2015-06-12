using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LittleJohn
{
    class LittleJohn
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> typesOfArrows = new Dictionary<string, List<int>>()
            { 
                {">>>----->>", new List<int>() },
                {">>----->", new List<int>() },
                {">----->", new List<int>() },
            };

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                foreach (var type in typesOfArrows.Keys)
                {
                    MatchCollection arrowsOfCurrentType = Regex.Matches(input, type);
                    typesOfArrows[type].Add(arrowsOfCurrentType.Count);
                    input = Regex.Replace(input, type, "");
                }
            }

            string result = string.Empty;
            foreach (var type in typesOfArrows.Reverse())
            {
                result += type.Value.Sum();
            }


            result = Convert.ToString(int.Parse(result), 2);
            result = result + string.Join("",result.Reverse());

            Console.WriteLine(Convert.ToInt32(result, 2));
        }
    }
}
