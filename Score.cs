using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceCalisthenics
{
    internal class Score
    {
        public int total = 0;
        public void Add(int points)
        {
            total += points;
        }

        public bool Iswinning()
        {
            return total >= 100; 
        }

        public void Display(string playerName)
        {
            Console.WriteLine($"{playerName} has a score of {total}.");
        }
    }
}
