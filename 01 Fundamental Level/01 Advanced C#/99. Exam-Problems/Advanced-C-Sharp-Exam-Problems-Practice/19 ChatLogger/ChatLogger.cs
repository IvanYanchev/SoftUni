using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatLogger
{
    class ChatLogger
    {
        static void Main(string[] args)
        {

            SortedList<DateTime, string> log = new SortedList<DateTime, string>();

            DateTime now = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string massage = input.Substring(0, input.LastIndexOf('/') - 1);
                string dateTime = input.Substring(input.LastIndexOf('/') + 2);
                log.Add(DateTime.ParseExact(dateTime, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture), massage);
            }

            foreach (var entry in log)
            {
                Console.WriteLine("<div>{0}</div>", SecurityElement.Escape(entry.Value));
            }

            TimeSpan ts = now - log.ElementAt(log.Count - 1).Key;
            DateTime last = log.ElementAt(log.Count - 1).Key;
            string lastActive = string.Empty;
            if (ts.TotalSeconds < 60 && now.Day == last.Day)
            {
                lastActive = "a few moments ago";
            }
            else if (ts.TotalMinutes < 60 && now.Day == last.Day)
            {
                lastActive = string.Format("{0} minute(s) ago", (int)ts.TotalMinutes);
            }
            else if (ts.TotalHours < 24 && now.Day == last.Day)
            {
                lastActive = string.Format("{0} hour(s) ago", (int)ts.TotalHours);
            }
            else if (now.Day - last.Day == 1) 
            {
                lastActive = string.Format("yesterday");
            }
            else
            {
                lastActive = last.ToString("dd-MM-yyyy");
            }

            Console.WriteLine("<p>Last active: <time>{0}</time></p>", lastActive);
        }
    }
}