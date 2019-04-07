using System;
using System.Collections.Generic;
using System.Text;

namespace BowingGameScoring
{
    public class BowlingGame
    {
        //Need a score function that returns an integer
        public int Score { get; private set; }

        //Need a roll function that returns an integer
        public void Roll(int pins)
        {
            Score += pins;
        }
        
    }
}
