using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerroristsWin_
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] ch = inputString.ToCharArray();
            List<int> pipePosition = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
			{
                if (inputString[i] == '|')
                {
                    pipePosition.Add(i);
                }
			}
            for (int i = 0; i < pipePosition.Count; i +=2)
            {
                int bombPower = 0;
                for (int j = pipePosition[i]+1; j < pipePosition[i+1]; j++)
                {
                    bombPower += ch[j];
                }
                for (int k = pipePosition[i] - bombPower % 10; k <= pipePosition[i + 1] + bombPower % 10; k++)
                {
                    if (k >= 0 && k < ch.Length)
                    {
                        ch[k] = '.';
                    }
                }
            }
            Console.WriteLine(string.Join("", ch));
        }
    }
}
