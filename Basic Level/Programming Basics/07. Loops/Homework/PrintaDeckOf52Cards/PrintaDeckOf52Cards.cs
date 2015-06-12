using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintaDeckOf52Cards
{
    class PrintaDeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string[] colours = { "♣", "♦", "♥", "♠" };

            foreach (var card in cards)
            {
                foreach (var colour in colours)
                {
                    Console.Write("{0,2}{1} ", card, colour);
                }
                Console.WriteLine();
            }
        }
    }
}
