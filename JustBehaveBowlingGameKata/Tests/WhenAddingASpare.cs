using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingASpare : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            SystemUnderTest.Add(3);
            SystemUnderTest.Add(7);
            SystemUnderTest.Add(3);
        }

        [Then]
        public void FrameOneScoreIsCorrect()
        {
            SystemUnderTest.ScoreForFrame(1).ShouldBe(13);
        }
    }
}
