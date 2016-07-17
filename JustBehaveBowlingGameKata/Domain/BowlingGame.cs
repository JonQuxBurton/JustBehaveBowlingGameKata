namespace JustBehaveBowlingGameKata.Domain
{
    public class BowlingGame
    {
        private int currentFrame = 0;
        private bool isFirstThrow = true;
        private Scorer scorer = new Scorer();

        public void Add(int pins)
        {
            scorer.AddThrow(pins);

            AdjustCurrentFrame(pins);
        }

        public int ScoreForFrame(int frame)
        {
            return scorer.ScoreForFrame(frame);
        }

        public int Score
        {
            get { return ScoreForFrame(currentFrame); }
        }
 
        private void AdjustCurrentFrame(int pins)
        {
            if (IsLastBallInFrame(pins))
                AdvanceFrame();
            else
                isFirstThrow = false;
        }

        private bool AdjustFrameForStrike(int pins)
        {
            if (pins == 10)
            {
                AdvanceFrame();
                return true;
            }

            return false;
        }

        private void AdvanceFrame()
        {
            currentFrame++;

            if (currentFrame > 10)
                currentFrame = 10;
        }

        private bool IsLastBallInFrame(int pins)
        {
            return IsStrike(pins) || !isFirstThrow;
        }

        private bool IsStrike(int pins)
        {
            return (isFirstThrow && pins == 10);
        }
    }
}
