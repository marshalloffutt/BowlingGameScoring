using System;
using Xunit;

namespace BowingGameScoring.Tests
{
    public class scoring_tests
    {
        [Fact]
        public void test01_can_make_a_new_game()
        {
            var game = new BowlingGame();
        }

        [Fact]
        public void test02_can_roll_gutter_game()
        {
            //Arrange--context--given
            var game = new BowlingGame();

            //Act--do the thing--when
            //20 total rolls in a bowling game
            game.RollMany(0, 20);

            //Assert--check the result--then
            Assert.Equal(0, game.Score);
        }

        [Fact]
        public void test03_can_roll_all_ones()
        {
            var game = new BowlingGame();

            game.RollMany(1, 20);

            Assert.Equal(20, game.Score);
        }

        [Fact]
        public void test04_can_roll_a_spare()
        {
            var game = new BowlingGame();

            game.Roll(7);
            game.Roll(3);
            game.Roll(4);
            game.RollMany(0, 17);

            Assert.Equal(18, game.Score);
        }

    }
}