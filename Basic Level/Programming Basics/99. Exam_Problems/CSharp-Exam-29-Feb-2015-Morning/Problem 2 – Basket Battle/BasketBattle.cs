using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Basket_Battle
{
    class BasketBattle
    {
        const int MaxPoints = 500;

        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = string.Empty;
            if (first == "Simeon")
            {
                second = "Nakov";
            }
            else
            {
                second = "Simeon";
            }

            Dictionary<string, int> scoreTable = new Dictionary<string, int>()
            {
                {first, 0},
                {second, 0},
            };
            
            int numberOfRounds = int.Parse(Console.ReadLine());
            string winner = string.Empty;
            string loser = string.Empty;
            int round = 0;

            for (int i = 1; i <= numberOfRounds; i++)
            {
                round = i;
                string roundFirst = first;
                string roundSecond = second;

                if (round % 2 == 0)
                {
                    roundFirst = second;
                    roundSecond = first;
                }

                scoreTable[roundFirst] = ShootBall(scoreTable, roundFirst);
                if (scoreTable[roundFirst] == MaxPoints)
                {
                    winner = roundFirst;
                    loser = roundSecond;
                    goto Win;
                }

                scoreTable[roundSecond] = ShootBall(scoreTable, roundSecond);
                if (scoreTable[roundSecond] == MaxPoints)
                {
                    winner = roundSecond;
                    loser = roundFirst;
                    goto Win;
                }
            }

            if (scoreTable[first] == scoreTable[second])
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(scoreTable[first]);
                return;
            }
            else
            {
                winner = first;
                if (scoreTable[first] < scoreTable[second])
                {
                    winner = second;
                }
                Console.WriteLine(winner);
                Console.WriteLine(Math.Abs(scoreTable[first] - scoreTable[second]));
                return;
            }

            Win:
                Console.WriteLine(winner);
                Console.WriteLine(round);
                Console.WriteLine(scoreTable[loser]);
        }

        static int ShootBall(Dictionary<string, int> scoreTable, string player)
        {
            int points = int.Parse(Console.ReadLine()); //number of points
            string information = Console.ReadLine(); // information about whether the shot was successful or not
            if (information == "success" && scoreTable[player] + points <= MaxPoints)
            {
                scoreTable[player] += points;
            }

            return scoreTable[player];
        }
    }
}
