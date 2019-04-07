using System;
using Xunit;

namespace BowingGameScoring.Tests
{
    public class scoring_tests
    {
        [Fact]
        public void can_make_new_game()
        {
            //Arrange--context--given
            var game = new BowlingGame();
        }

        [Fact]
        public void can_roll_gutter_game()
        {
            //Arrange--context--given
            var game = new BowlingGame();

            //Act--do the thing--when
            for (var i = 0; i < 20; i++)
                game.Roll(0);

            //Assert--check the result--then
            Assert.Equal(0, game.Score);
        }
    }
}