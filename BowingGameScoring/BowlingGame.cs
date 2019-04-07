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

        //Roll all the frames
        public void RollMany(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
                Roll(pins);
        }
        
    }
}
