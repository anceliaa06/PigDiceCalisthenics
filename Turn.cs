using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceCalisthenics
{
    internal class Turn
    {
        private Dice dice = new Dice();
        private int turnScore = 0;

        public void Play(Player player)
        {
            Console.WriteLine($"\n {player.Name()}'s turn begins.");

            while (true)
            {
                Console.WriteLine("Press 'r' to roll the dice or 'h' to hold your score.");
                string input = Console.ReadLine();

                if (input == "r")
                {
                    int roll = dice.Roll();
                    Console.WriteLine($"Rolled: {roll}");

                    if (roll == 1)
                    {
                        Console.WriteLine("You rolled a 1! Turn ends with no points added.");
                        turnScore = 0;
                        break;
                    }
                    else
                    {
                        turnScore += roll;
                        Console.WriteLine($"Current turn score: {turnScore}");
                    }
                }
                else if (input == "h") // Fixed misplaced 'else if' block
                {
                    player.AddPoints(turnScore);
                    Console.WriteLine($"Holding. {turnScore} points added.");
                    break; // Added break to exit the loop after holding
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press 'r' to roll or 'h' to hold.");
                }
            }
        }
    }
}
