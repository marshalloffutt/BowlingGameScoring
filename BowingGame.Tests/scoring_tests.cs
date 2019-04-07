using System;
using Xunit;

namespace BowingGameScoring.Tests
{
    public class scoring_tests
    {

        [Fact]
        public void test02_can_roll_gutter_game()
        {
            //Arrange--context--given
            var game = new BowlingGame();

            //Act--do the thing--when
            //20 total rolls in a bowling game
            for (var i = 0; i < 20; i++)
                game.Roll(0);

            //Assert--check the result--then
            Assert.Equal(0, game.Score);
        }

        [Fact]
        public void test03_can_roll_all_ones()
        {

        }
    }
}