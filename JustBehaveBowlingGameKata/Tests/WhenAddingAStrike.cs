using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingAStrike : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            SystemUnderTest.Add(10);
            SystemUnderTest.Add(3);
            SystemUnderTest.Add(6);
        }

        [Then]
        public void FrameOneScoreIsCorrect()
        {
            SystemUnderTest.ScoreForFrame(1).ShouldBe(19);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(28);
        }
    }
}
