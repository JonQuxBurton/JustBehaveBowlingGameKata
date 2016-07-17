using Shouldly;
using JustBehave;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingAHeartBreakGame : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            for (var i = 0; i < 11; i++)
                SystemUnderTest.Add(10);
            
            SystemUnderTest.Add(9);
        }
        
        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(299);
        }
    }
}
