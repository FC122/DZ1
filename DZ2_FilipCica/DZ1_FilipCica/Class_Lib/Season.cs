using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Lib
{
    public class Season
    {
        Episode[] episodes;
        int NumberOfSeason;
        int Viewers;
        
        
        public int Length
        {
            get { return episodes.Length; }
        }

        TimeSpan DuriationSum()
        {
            TimeSpan Duriation=new TimeSpan(0);
            for (int i = 0; i < episodes.Length; i++)
            {
                Duriation += episodes[i].GetDuriation();
            }
            return Duriation;
        }

        int ViewersSum()
        {
            int Sum=0;
            for (int i = 0; i <episodes.Length; i++)
            {
                Sum += episodes[i].GetViewerCount();
            }
            Viewers = Sum;
            return Sum;
        }
 
        public Season(int NumberOfSeason, Episode[] episodes)
        {
            this.episodes = episodes;
            this.NumberOfSeason = NumberOfSeason;
        }

     
        public Episode this[int index]
        {
            get { return episodes[index]; }
            set { episodes[index] = value; }
        }

        public override string ToString()
        {
            return $"Season{NumberOfSeason}:\n"+
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
