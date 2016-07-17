using Shouldly;
using JustBehave;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingAPerfectGame : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            for (var i=0; i<12; i++)
            {
                SystemUnderTest.Add(10);
            }
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(300);
        }
    }
}
