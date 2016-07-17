using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingFourThrowsWithNoMarkcs : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            SystemUnderTest.Add(5);
            SystemUnderTest.Add(4);
            SystemUnderTest.Add(7);
            SystemUnderTest.Add(2);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(18);
        }

        [Then]
        public void FrameOneScoreIsCorrect()
        {
            SystemUnderTest.ScoreForFrame(1).ShouldBe(9);
        }

        [Then]
        public void FrameTwoScoreIsCorrect()
        {
            SystemUnderTest.ScoreForFrame(2).ShouldBe(18);
        }
    }
}
