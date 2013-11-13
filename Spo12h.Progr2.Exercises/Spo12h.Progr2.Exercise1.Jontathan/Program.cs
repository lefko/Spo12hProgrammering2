using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise1.Jontathan
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter your Name: ");
            var name = Console.ReadLine();

            var player = new Player(name);

            Console.WriteLine("Do you want to play 9 or 18 Holes?");
            Console.WriteLine("Enter 1 for 9 Holes or 2 for 18 holes");
            var number = Console.ReadLine();

            ScoreCard scoreCard;

            switch (number)
            {
                case "1":
                    scoreCard = new ScoreCard(player, 9);
                    break;
                case "2":
                    scoreCard = new ScoreCard(player, 18);
                    break;
                default:
                    return;
            }

            while (!scoreCard.IsCompleted)
            {
                Console.Write("Enter your score for hole {0}: ", scoreCard.GetCurrentHole()+1);
                scoreCard.SetScore(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Your total score is: {0}", scoreCard.TotalScore);
        }
    }

}
