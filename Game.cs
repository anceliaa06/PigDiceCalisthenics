using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceCalisthenics
{
    internal class Game
    {
        private Player player1;
        private Player player2;
        private Turn turn = new Turn();

        public Game()
        {
            Console.WriteLine("ENTER PLAYER 1 NAME:");
            player1 = new Player(Console.ReadLine());

            Console.WriteLine("ENTER PLAYER 2 NAME:");
            player2 = new Player(Console.ReadLine());
        }

        public void Start()
        {
            while (true)
            {
                turn.Play(player1);
                player1.ShowScore();
                if (player1.HasWon())
                {
                    Console.WriteLine($"{player1.Name()} wins!");
                    break;
                }
                turn.Play(player2);
                player2.ShowScore();
                if (player2.HasWon())
                {
                    Console.WriteLine($"{player2.Name()} wins!");
                    break;
                }
            }
        }

    }
}
