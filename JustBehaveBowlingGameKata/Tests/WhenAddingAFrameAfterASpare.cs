using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingAFrameAfterASpare : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            SystemUnderTest.Add(3);
            SystemUnderTest.Add(7);
            SystemUnderTest.Add(3);
            SystemUnderTest.Add(2);
        }
        
        [Then]
        public void FrameOneScoreIsCorrect()
        {
            SystemUnderTest.ScoreForFrame(1).ShouldBe(13);
        }

        [Then]
        public void FrameTwoScoreIsCorrect()
        {
            SystemUnderTest.ScoreForFrame(2).ShouldBe(18);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(18);
        }
    }
}
