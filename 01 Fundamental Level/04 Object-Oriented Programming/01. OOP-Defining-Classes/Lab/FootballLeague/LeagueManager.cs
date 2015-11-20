using System;
using System.Linq;
using FootballLeague.Models;

namespace FootballLeague
{
    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split(' ');
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;
            }
        }

        private static void ListMatches()
        {
            foreach (Match match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }

        private static void ListTeams()
        {
            foreach (Team team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void AddMatch(int id, string homeTeamName, string awayTeamName, int goalsHomeTeam, int goalsAwayTeam)
        {
            if (League.Matches.Any(m => m.Id == id))
            {
                throw new InvalidOperationException("Match is already in this league");
            }

            Team homeTeam = League.Teams.First(t => t.Name == homeTeamName);
            Team awayTeam = League.Teams.First(t => t.Name == awayTeamName);
            Score score = new Score(goalsHomeTeam, goalsAwayTeam);

            League.AddMatch(new Match(homeTeam, awayTeam , score, id));
            Console.WriteLine("Match {0} added to the league", id);
        }

        private static void AddPlayerToTeam(string firstname, string lastName, DateTime dateOfBirth, decimal salary, string teamName)
        {
            Team team = League.Teams.First(t => t.Name == teamName);
            Player player = new Player(firstname, lastName, salary, dateOfBirth, team);

            team.AddPlayer(player);
        }

        private static void AddTeam(string name, string nickname, DateTime dateOfFounding)
        {
            if (League.Teams.Any(t => t.Name == name))
            {
                throw new InvalidOperationException("Team is already in this league");
            }

            League.AddTeam(new Team(name, nickname, dateOfFounding));
            Console.WriteLine("Team {0} added to the league", name);
        }
    }
}
