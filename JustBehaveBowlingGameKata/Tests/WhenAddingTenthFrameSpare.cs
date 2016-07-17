using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingTenthFrameSpare : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            for (var i = 0; i < 9; i++)
                SystemUnderTest.Add(10);

            SystemUnderTest.Add(9);
            SystemUnderTest.Add(1);
            SystemUnderTest.Add(1);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(270);
        }
    }
}
