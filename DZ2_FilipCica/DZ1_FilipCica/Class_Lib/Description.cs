using System;

namespace Class_Lib
{
    public class Description
    {
        int EpisodeNumber { get;}
        TimeSpan EpisodeDuriation { get;}
        string EpisodeName { get; }

        public Description(string EpisodeNumber,string EpisodeDuriation,string EpisodeName)
        {
            this.EpisodeNumber = int.Parse(EpisodeNumber);
            this.EpisodeDuriation = TimeSpan.Parse(EpisodeDuriation);
            this.EpisodeName = EpisodeName;
        }

        public Description(int episodeNumber, TimeSpan episodeDuriation, string episodeName)
        {
            EpisodeNumber = episodeNumber;
            EpisodeDuriation = episodeDuriation;
            EpisodeName = episodeName;
        }

        public override string ToString()
        {
            return $"{EpisodeNumber},{EpisodeDuriation},{EpisodeName}";
        }

      

        public Description()
        {
            EpisodeNumber = 0;
            EpisodeDuriation = new TimeSpan(0,0,0);
            EpisodeName = "NoName";
        }
    }
}
