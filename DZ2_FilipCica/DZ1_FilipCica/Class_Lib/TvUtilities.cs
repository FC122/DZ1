using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using static Class_Lib.RandomScore;

namespace Class_Lib
{
   public static class TvUtilities
    {
        
        public static Episode Parse(string episodeInput)
        {
            string[] Episode;
            Episode=episodeInput.Split(',');
            //Console.WriteLine(Episode[2]);
            Description descriptions = new Description(Convert.ToString(Episode[3]), Convert.ToString(Episode[4]), Convert.ToString(Episode[5]));
            return new Episode(Episode[0],Episode[1],Episode[2],descriptions);

        }
        

        public static void Sort(Episode[] episodes)
        {
            for (int j = episodes.Length-1; j!=0; j--)
            {
                for (int i = episodes.Length-1; i !=0; i--)
                {
                    if (episodes[i] > episodes[i - 1])
                    {
                        Episode temporary;

                        temporary = episodes[i];
                        episodes[i] = episodes[i - 1];
                        episodes[i -1] = temporary;
                    }
                }
            }
        }
        
    }
}
