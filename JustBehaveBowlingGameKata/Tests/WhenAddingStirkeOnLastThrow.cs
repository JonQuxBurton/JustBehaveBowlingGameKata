using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingStirkeOnLastThrow : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            for (var i = 0; i < 9; i++)
            {
                SystemUnderTest.Add(0);
                SystemUnderTest.Add(0);
            }

            SystemUnderTest.Add(2);
            SystemUnderTest.Add(8);
            SystemUnderTest.Add(10);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(20);
        }

    }
}
