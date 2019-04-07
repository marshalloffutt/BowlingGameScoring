using System;
using Xunit;

namespace BowingGameScoring.Tests
{
    public class scoring_tests
    {
        [Fact]
        public void can_make_new_game()
        {
            var newGame = new BowlingGame();
        }
    }
}