using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingTwoThrowsWithNoMark : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            SystemUnderTest.Add(5);
            SystemUnderTest.Add(4);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(9);
        }
    }
}
