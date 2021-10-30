using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Ranking
{
    class Contest
    {
        private string name;
        private int points;

        public Contest()
        {

        }

        public Contest(string name , int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Points
        {
            get => points;
            set => points = value;
        }
    }
}
