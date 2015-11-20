using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Team HomeTeam
        {
            get { return this.homeTeam; }
            set { this.homeTeam = value; }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set { this.awayTeam = value; }
        }

        public Score Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("{0}. {1} - {2} {3}", this.id, this.HomeTeam.Name, this.AwayTeam.Name, this.Score);
        }
    }
}
