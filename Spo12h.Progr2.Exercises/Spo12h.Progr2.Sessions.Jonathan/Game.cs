using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Spo12h.Progr2.Sessions.Jonathan
{
    class Game
    {
        private Player player1;
        private Player player2;
        private Player[,] board;

        public Player CurrentPlayer { get; set; }

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.board = new Player[3, 3];
            this.CurrentPlayer = player1;
        }

        public bool IsCompleted { get { return false; } }

        internal string GetCurrentBoard()
        {
            var boardString = new StringBuilder();
            boardString.AppendLine("  A B C");
            for (var i = 0; i < 3; i++)
                boardString.AppendFormat("{0} {1} {2} {3} \n",
                    i + 1,
                    BoardChar(board[i, 0]),
                    BoardChar(board[i, 1]),
                    BoardChar(board[i, 2]));

            return boardString.ToString();
        }

        private object BoardChar(Player player)
        {
            if (player == null)
                return " ";
            else
                return player.BoardChar;
        }


        internal void MarkSquare(string position)
        {
            int x, y;
            if(position.Length != 2)
                return;
            switch (position[0])
            {
                case '1' : y = 0; break;
                case '2' : y = 1; break;
                case '3' : y = 2; break;
                default : return;
            }

            switch (position[1])
            {
                case 'A': x = 0; break;
                case 'B': x = 1; break;
                case 'C': x = 2; break;
                default: return;
            }

            if (board[y, x] != null)
                return;

            board[y, x] = CurrentPlayer;
            SwapPlayers();
        }

        private void SwapPlayers()
        {
            if (CurrentPlayer == player1)
                CurrentPlayer = player2;
            else
                CurrentPlayer = player1;
        }
    }
}
