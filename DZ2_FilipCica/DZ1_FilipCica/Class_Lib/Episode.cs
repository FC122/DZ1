using System;
using System.Numerics;

namespace Class_Lib
{
    public class Episode
    {
        int ViewerCount;
        decimal ScoreSum;
        decimal MaxScore;
        Description descriptions = new Description();

        public TimeSpan GetDuriation()
        {
            return descriptions.GetEpisodeDuriation();
        }

        public Episode(string ViewerCount, string ScoreSum, string MaxScore, Description descriptions)
        {
            this.ViewerCount = int.Parse(ViewerCount);
            this.ScoreSum = decimal.Parse(ScoreSum);
            this.MaxScore = decimal.Parse(MaxScore);
            this.descriptions = descriptions;
        }

        public Episode()
        {
            ViewerCount = 0;
            ScoreSum = 0;
            MaxScore = 0;
            descriptions = null;
        }
        public Episode(int ViewerCount, double ScoreSum, double MaxScore, Description descriptions)
        {
            this.ViewerCount = ViewerCount;
            this.ScoreSum = Convert.ToDecimal(ScoreSum);
            this.MaxScore = Convert.ToDecimal(MaxScore);
            this.descriptions = descriptions;

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

        public override string ToString()
        {
            return $"{ViewerCount},{ScoreSum},{MaxScore},{descriptions}";
        }

        public static bool operator ==(Episode episode1, Episode episode2)
        {
            decimal AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            decimal AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;
            if (AvreageScoreofEpisode1 == AvreageScoreofEpisode2)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Episode episode1, Episode episode2)
        {
            decimal AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            decimal AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;

            return !(AvreageScoreofEpisode1 == AvreageScoreofEpisode2);
        }

        public static bool operator <(Episode episode1, Episode episode2)
        {
            decimal AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            decimal AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;

            if (AvreageScoreofEpisode1 < AvreageScoreofEpisode2) { return true; }
            else { return false; }

        }
        public static bool operator >(Episode episode1, Episode episode2)
        {
            decimal AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            decimal AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;

            if (AvreageScoreofEpisode1 > AvreageScoreofEpisode2) { return true; }
            else { return false; }

        }

    }

}