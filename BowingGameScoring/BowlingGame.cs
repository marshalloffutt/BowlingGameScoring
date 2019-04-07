using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowingGameScoring
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        //Need a score function that returns an integer
        public int Score
        {
            get
            {
                var score = 0;
                var rollIndex = 0;

                //Loop over frames
                for (var frame = 0; frame < 10; frame++)
                {
                    //Check to see if a spare is rolled
                    if (IsSpare(rollIndex))
                    {
                        score += GetSpareScore(rollIndex);
                    }
                    else
                    {
                        score += GetStandardScore(rollIndex);
                    }

                    rollIndex += 2;
                }

                return score;
            }
        }

        private int GetStandardScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }

        private int GetSpareScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }

        private bool IsSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }

        //Need a roll function that returns an integer
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        //Multiple rolls
        public void RollMany(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
                Roll(pins);
        }
        
    }
}
