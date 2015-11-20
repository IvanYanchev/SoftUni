using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLeague.Models
{
    public class Team
    {
        private const int MinimumAllowedDateOfFounding = 1850;
        private string name;
        private string nickname;
        private DateTime dateOfFounding;
        private List<Player> players;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("The name should be at least 5 characters long");
                }
                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("The nickname should be at least 5 characters long");
                }
                this.nickname = value;
            }
        }

        public DateTime DateOfFounding
        {
            get { return this.dateOfFounding; }
            set
            {
                if (value.Year < MinimumAllowedDateOfFounding)
                {
                    throw new ArgumentException("The year of founding cannot be earlier than " + MinimumAllowedDateOfFounding);
                }
                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.players;
            }
        }

        public Team(string name, string nickname, DateTime dateOfFounding)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists in this team");
            }
            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return string.Format("Team {0}, a.k.a. {1}, founded {2}", this.Name, this.Nickname, this.DateOfFounding.ToShortDateString());
        }
    }
}
