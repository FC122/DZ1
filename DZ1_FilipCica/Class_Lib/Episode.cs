using System;

namespace Class_Lib
{
    public class Episode
    {
        int ViewerCount;
        decimal ScoreSum;
        decimal MaxScore;

        public Episode()
        {
            ViewerCount = 0;
            ScoreSum = 0;
            MaxScore = 0;
        }
        public Episode(int ViewerCount, double ScoreSum, double MaxScore)
        {
            this.ViewerCount = ViewerCount;
            this.ScoreSum = Convert.ToDecimal(ScoreSum);
            this.MaxScore = Convert.ToDecimal(MaxScore);
            MaxScore = 0;
            ScoreSum = 0;
        }
        public void AddView(decimal Score)
        {
            ViewerCount++;
            this.ScoreSum += Score;
            if (Score > MaxScore) { MaxScore = Score; }
        }

        public decimal GetMaxScore()
        {
            return MaxScore;
        }

        public int GetViewerCount()
        {
            return ViewerCount;
        }

        public decimal GetAverageScore()
        {
            return (ScoreSum / ViewerCount);
        }

    }
}
