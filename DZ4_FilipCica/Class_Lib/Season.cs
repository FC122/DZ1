using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Lib
{
    public class Season:IEnumerable<Episode>
    {
        //Episode[] episodes;
        List<Episode> episodes;
        int NumberOfSeason;
        int Viewers;

        public int Length
        {
            get { return episodes.Count; }
        }

        TimeSpan DuriationSum()
        {
            TimeSpan Duriation=new TimeSpan(0);
            for (int i = 0; i < episodes.Count; i++)
            {
                Duriation += episodes[i].GetDuriation();
            }
            return Duriation;
        }

        int ViewersSum()
        {
            int Sum=0;
            for (int i = 0; i <episodes.Count; i++)
            {
                Sum += episodes[i].GetViewerCount();
            }
            Viewers = Sum;
            return Sum;
        }
 
        public Season(int NumberOfSeason, List<Episode> episodes)
        {
            this.episodes = episodes;
            this.NumberOfSeason = NumberOfSeason;
        }

        public Season(Season season)
        {
            this.episodes = season.episodes;
            this.NumberOfSeason = season.NumberOfSeason;
            this.Viewers = season.Viewers;
        }

        public Episode this[int index]
        {
            get { return episodes[index]; }
            set { episodes.Insert(index, value); }
        }

        public IEnumerator<Episode> GetEnumerator()
        {
            foreach(Episode episode in episodes)
            {
                yield return episode;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Remove(string str)
        {
            foreach (Episode episode in episodes)
            {
                if (str == episode.EpisodeDescription.GetEpisodeName()) { episodes.Remove(episode); return; }
            }

            throw new TvException(str,"No souch episode found."); 
        }


        public override string ToString()
        {
            return $"Season {NumberOfSeason}.:\n"+
                   $"=========================================================\n" +
                   $"{string.Join<Episode>(Environment.NewLine, episodes)}\n" +
                   $"Report:\n" +
                   $"=========================================================\n" +
                   $"Total viewers:{ViewersSum()}\n" +
                   $"Total duriation:{DuriationSum()}\n" +
                   $"=========================================================\n";
        }
    }
}
