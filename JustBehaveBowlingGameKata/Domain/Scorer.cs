namespace JustBehaveBowlingGameKata.Domain
{
    public class Scorer
    {
        private int ball;
        private int[] throws = new int[21];
        private int currentThrow;

        public void AddThrow(int pins)
        {
            throws[currentThrow++] = pins;
        }

        public int ScoreForFrame(int frame)
        {
            ball = 0;
            var score = 0;

            for (var currentFrame = 0; currentFrame < frame; currentFrame++)
            {
                if (IsStrike())
                {
                    score += 10 + NextTwoBallsForStrike;
                    ball++;
                }
                else if (IsSpare())
                {
                    score += 10 + NextBallForSpare;
                    ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame;
                    ball += 2;
                }
            }

            return score;
        }

        private bool IsSpare()
        {
            return (throws[ball] + throws[ball + 1]) == 10;
        }

        private bool IsStrike()
        {
            return throws[ball] == 10;
        }

        private int NextBallForSpare
        {
            get { return throws[ball + 2]; }
        }

        private int NextTwoBallsForStrike
        {
            get { return (throws[ball + 1] + throws[ball + 2]); }
        }

        private int NextTwoBalls
        {
            get { return (throws[ball] + throws[ball + 1]); }
        }

        private int TwoBallsInFrame
        {
            get { return throws[ball] + throws[ball + 1]; }
        }
    }
}
