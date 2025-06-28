using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceCalisthenics
{
    internal class Player
    {
        private string name;
        private Score score;

        public Player(string name)
        {
            this.name = name;
            this.score = new Score();
        }

        public string Name()
        {
             return name; 
        }

        public void AddPoints(int points)
        {
            score.Add(points);
        }

        public bool HasWon()
        {
            return score.Iswinning();
        }
        public void ShowScore()
        {
            score.Display(name);
        }
    }
}
