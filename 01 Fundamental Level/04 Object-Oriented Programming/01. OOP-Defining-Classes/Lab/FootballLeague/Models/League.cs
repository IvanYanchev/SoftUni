using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public static class League
    {
        private static List<Match> matches = new List<Match>();
        private static List<Team> teams = new List<Team>();

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static void AddTeam(Team team)
        {
            if (teams.Any(t => t.Name == team.Name))
            {
                throw new InvalidOperationException("Team is already in this league");
            }
            teams.Add(team);
        }

        public static void AddMatch(Match match)
        {
            if (matches.Any(m => m.Id == match.Id))
            {
                throw new InvalidOperationException("Match is already in this league");
            }
            matches.Add(match);
        }
    }
}
