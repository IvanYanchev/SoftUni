using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladkosNotebook
{
    public class Page
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Opponents { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }

    class VladkosNotebook
    {
        static void RecoverDataToNotebook(Dictionary<string, Page> notebook, string input)
        {
            string[] info = input.Split('|');
            if (!notebook.ContainsKey(info[0]))
            {
                notebook.Add(info[0], new Page());
            }

            switch (info[1])
            {
                case "age":
                    {
                        notebook[info[0]].Age = int.Parse(info[2]);
                        break;
                    }
                case "name":
                    {
                        notebook[info[0]].Name = info[2];
                        break;
                    }
                case "win":
                    {
                        if (notebook[info[0]].Opponents == null)
                        {
                            notebook[info[0]].Opponents = new List<string>();
                        }
                        notebook[info[0]].Wins += 1;
                        notebook[info[0]].Opponents.Add(info[2]);
                        break;
                    }
                case "loss":
                    {
                        if (notebook[info[0]].Opponents == null)
                        {
                            notebook[info[0]].Opponents = new List<string>();
                        }
                        notebook[info[0]].Losses += 1;
                        notebook[info[0]].Opponents.Add(info[2]);
                        break;
                    }
            }
        }




        static void Main(string[] args)
        {
            Dictionary<string, Page> notebook = new Dictionary<string, Page>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine.Equals("end", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    RecoverDataToNotebook(notebook, inputLine);
                }
            }
            bool isNotRecoveredAnyData = true;
            foreach (var pageColor in notebook.OrderBy(x => x.Key))
            {
                //Color: purple
                //-age: 99
                //-name: VladoKaramfilov
                //-opponents: Kiko, Kiko, Kiko, Manov, Manov, Yana, Yana, Yana
                //-rank: 0.11
                if (pageColor.Value.Name != null && pageColor.Value.Age != 0)
                {
                    isNotRecoveredAnyData = false;
                    Console.WriteLine("Color: {0}", pageColor.Key);
                    Console.WriteLine("-age: {0}", pageColor.Value.Age);
                    Console.WriteLine("-name: {0}", pageColor.Value.Name);
                    Console.WriteLine("-opponents: {0}", pageColor.Value.Opponents == null ? "(empty)" : string.Join(", ", pageColor.Value.Opponents.OrderBy(name => name, StringComparer.Ordinal)));
                    Console.WriteLine("-rank: {0:0.00}", ((double)pageColor.Value.Wins + 1) / ((double)pageColor.Value.Losses + 1));
                }
            }
            if (isNotRecoveredAnyData)
            {
                Console.WriteLine("No data recovered.");   
            }
        }
    }
}
