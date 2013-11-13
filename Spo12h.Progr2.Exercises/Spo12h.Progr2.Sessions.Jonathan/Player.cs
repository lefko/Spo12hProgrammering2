using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h.Progr2.Sessions.Jonathan
{
    class Player
    {
        public string Name { get; private set; }
        public string BoardChar { get; private set; }

        public Player(string name, string boardChar)
        {
            this.Name = name;
            this.BoardChar = boardChar;
        }

        
    }
}
