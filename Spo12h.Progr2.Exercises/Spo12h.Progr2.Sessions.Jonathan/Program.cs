using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Sessions.Jonathan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Player 1 Name: ");
            var name1 = Console.ReadLine();
            var player1 = new Player(name1, "X");

            Console.Write("Player 2 Name: ");
            var name2 = Console.ReadLine();
            var player2 = new Player(name2, "O");

            Console.WriteLine("{0} ({1}) will play {2} ({3})", 
                player1.Name, player1.BoardChar,
                player2.Name, player2.BoardChar);

            var game = new Game(player1, player2);
            while (!game.IsCompleted)
            {
                Console.WriteLine(game.GetCurrentBoard());
                Console.Write("{0}, make your move: ",
                    game.CurrentPlayer.Name);
                var position = Console.ReadLine();
                game.MarkSquare(position);
            }

            Console.ReadKey();
        }
    }
}
