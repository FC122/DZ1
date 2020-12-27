using System;
using System.Numerics;

namespace Class_Lib
{
    public class Episode
    {
        int ViewerCount;
        double ScoreSum;
        double MaxScore;
        Description description = new Description();

     public Description EpisodeDescription
        {
            get { return description; }
        }


        public TimeSpan GetDuriation()
        {
            return description.GetEpisodeDuriation();
        }

        public Episode(string ViewerCount, string ScoreSum, string MaxScore, Description descriptions)
        {
            this.ViewerCount = int.Parse(ViewerCount);
            this.ScoreSum = double.Parse(ScoreSum);
            this.MaxScore = double.Parse(MaxScore);
            this.description = descriptions;
        }

        public Episode()
        {
            ViewerCount = 0;
            ScoreSum = 0;
            MaxScore = 0;
            description = null;
        }
        public Episode(int ViewerCount, double ScoreSum, double MaxScore, Description descriptions)
        {
            this.ViewerCount = ViewerCount;
            this.ScoreSum = ScoreSum;
            this.MaxScore = MaxScore;
            this.description = descriptions;

        }
        public void AddView(double Score)
        {
            ViewerCount++;
            this.ScoreSum += Score;
            if (Score > MaxScore) { MaxScore = Score; }
        }

        public double GetMaxScore()
        {
            return MaxScore;
        }

        public int GetViewerCount()
        {
            return ViewerCount;
        }

        public double GetAverageScore()
        {
            return (ScoreSum / ViewerCount);
        }

        public override string ToString()
        {
            return $"{ViewerCount},{ScoreSum},{MaxScore},{description}";
        }

        public static bool operator ==(Episode episode1, Episode episode2)
        {
            double AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            double AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;
            if (AvreageScoreofEpisode1 == AvreageScoreofEpisode2)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Episode episode1, Episode episode2)
        {
            double AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            double AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;

            return !(AvreageScoreofEpisode1 == AvreageScoreofEpisode2);
        }

        public static bool operator <(Episode episode1, Episode episode2)
        {
            double AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            double AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;

            if (AvreageScoreofEpisode1 < AvreageScoreofEpisode2) { return true; }
            else { return false; }

        }
        public static bool operator >(Episode episode1, Episode episode2)
        {
            double AvreageScoreofEpisode1 = episode1.ScoreSum / episode1.ViewerCount;
            double AvreageScoreofEpisode2 = episode2.ScoreSum / episode2.ViewerCount;

            if (AvreageScoreofEpisode1 > AvreageScoreofEpisode2) { return true; }
            else { return false; }

        }

    }

}