using JustBehave;
using Shouldly;

namespace JustBehaveBowlingGameKata.Tests
{
    public class WhenAddingSampleGame : GivenABowlngGame
    {
        protected override void Given() { }

        protected override void When()
        {
            SystemUnderTest.Add(1);
            SystemUnderTest.Add(4);
            SystemUnderTest.Add(4);
            SystemUnderTest.Add(5);
            SystemUnderTest.Add(6);
            SystemUnderTest.Add(4);
            SystemUnderTest.Add(5);
            SystemUnderTest.Add(5);
            SystemUnderTest.Add(10);
            SystemUnderTest.Add(0);
            SystemUnderTest.Add(1);
            SystemUnderTest.Add(7);
            SystemUnderTest.Add(3);
            SystemUnderTest.Add(6);
            SystemUnderTest.Add(4);
            SystemUnderTest.Add(10);
            SystemUnderTest.Add(2);
            SystemUnderTest.Add(8);
            SystemUnderTest.Add(6);
        }

        [Then]
        public void ScoreIsCorrect()
        {
            SystemUnderTest.Score.ShouldBe(133);
        }
    }
}
