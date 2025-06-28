using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceCalisthenics
{
    internal class Dice
    {
        private Random random = new Random();

        public int Roll()
        {
            return random.Next(1, 7); 
        }
    }
}
