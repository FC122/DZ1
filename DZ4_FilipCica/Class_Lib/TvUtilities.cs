using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Text;
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

        public static double GenerateRandomScore()
        {
            Random RandomNumber = new Random();
            int I;
            int D;
            double d;
            I = RandomNumber.Next(1, 10);
            if (I == 10) { return 100; }
            D = RandomNumber.Next(0, 999);
            d = D / 1000;
            // Console.WriteLine(d);
            I = I % 10;
            //Console.WriteLine(I+d);
            return (I + d);

        }

        public static List<Episode> LoadEpisodesFromFile(string filename)
        {


            string[] episodesInputs = File.ReadAllLines(filename);
            List<Episode> episodes = new List<Episode>();
            for(int i = 0; i < episodesInputs.Length; i++)
			{
                //episodes[i] = Parse(episodesInputs[i]);
                episodes.Add(Parse(episodesInputs[i]));
            }
            /*Episode[] episodes = new Episode[10];
            string line;
            int i = 0;
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] split=line.Split(',');
                    episodes[i] = new Episode(split[0],split[1],split[2],new Description(split[4],split[5],split[6]));
                        i++;
                }
            }
            */
            return episodes;
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
