using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlDispatcher
{
    public class ElementBuilder
    {
        private string element = null;

        public void AddAtribute(string attribute, string value)
        {
            int insertIndex = element.IndexOf('>');
            string insertAttr = string.Format(" {0}=\"{1}\"", attribute, value);
            this.element = this.element.Insert(insertIndex, insertAttr);
        }

        public void AddContent(string content)
        {
            int insertIndex = element.IndexOf('>') + 1;
            this.element = this.element.Insert(insertIndex, content);
        }

        public ElementBuilder()
        {

        }

        public ElementBuilder(string name)
        {
            this.element = string.Format("<{0}></{0}>", name);
        }

        public static string operator *(ElementBuilder element, int multiplier)
        {
            string result = null;
            for (int i = 0; i < multiplier; i++)
            {
                result += element.ToString();
            }
            return result;
        }

        public override string ToString()
        {
            return this.element;
        }
    }
}
