using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Spo12h.Progr2.Exercise1.Jontathan
{
    class ScoreCard
    {
        public Player Player { get; private set; }
        public int[] NumberOfHoles { get; private set; }
        public bool IsCompleted { get; private set; }
        public int CurrentHole { get; private set; }
        //public int 

        public ScoreCard(Player player, int numberOfHoles)
        {
            this.Player = player;
            this.NumberOfHoles = new int[numberOfHoles];
            this.IsCompleted = false;
            this.CurrentHole = 0;
        }

        internal int GetCurrentHole()
        {
            return CurrentHole;
        }

        internal void SetScore(int score)
        {
            //while (NumberOfHoles[GetCurrentHole()] < NumberOfHoles.Length)
            //for (int i = 0; i <= NumberOfHoles.Length; i++)
            //{
                    if (NumberOfHoles[GetCurrentHole()] == 0)
                    {
                        if (score > 8)
                            score = 8;
                        this.NumberOfHoles[GetCurrentHole()] = score;
                        this.CurrentHole++;
                    }
            if (CurrentHole == this.NumberOfHoles.Length)
                IsCompleted = true;
            //}
        }

        public int TotalScore
        {
            get
            {
                int result = 0;
                foreach (int i in NumberOfHoles)
                {
                    result += i;
                }
                return result;
            }
        }

    }
}
