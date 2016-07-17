using JustBehave;
using JustBehaveBowlingGameKata.Domain;

namespace JustBehaveBowlingGameKata.Tests
{
    public abstract class GivenABowlngGame : XBehaviourTest<BowlingGame>
    {
        protected override BowlingGame CreateSystemUnderTest()
        {
            return new BowlingGame();
        }
    }
}
