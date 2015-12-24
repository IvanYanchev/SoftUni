using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Score
    {
        private string _name;
        private int _points;

        public Score()
        {
        }

        public Score(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Points
        {
            get
            {
                return _points;
            }

            set
            {
                _points = value;
            }
        }
    }
}
