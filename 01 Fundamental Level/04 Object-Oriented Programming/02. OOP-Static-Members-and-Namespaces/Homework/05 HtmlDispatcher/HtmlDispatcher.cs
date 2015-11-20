using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlDispatcher
{
    public static class HtmlDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");

            img.AddAttribute("src", imageSource);
            img.AddAttribute("alt", alt);
            img.AddAttribute("title", title);

            return img.ToString();
        }

        public static string CreateURL(string urlString, string title, string text)
        {
            ElementBuilder url = new ElementBuilder("a");

            url.AddAttribute("href", urlString);
            url.AddAttribute("title", title);
            url.AddContent(text);

            return url.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");

            input.AddAttribute("type", inputType);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);

            return input.ToString();
        }
    }
}
