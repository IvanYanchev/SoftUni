using System;

namespace FootballLeague.Models
{
    public class Score
    {
        private int awayTeamGoals;
        private int homeTeamGoals;

        public int AwayTeamGoals
        {
            get
            {
                return awayTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The goals cannot be negative");
                }
                awayTeamGoals = value;
            }
        }

        public int HomeTeamGoals
        {
            get
            {
                return homeTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The goals cannot be negative");
                }
                homeTeamGoals = value;
            }
        }

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", this.HomeTeamGoals, this.AwayTeamGoals);
        }
    }
}
