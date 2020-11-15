using System;
using  Class_Lib;
using static Class_Lib.RandomScore;

namespace DZ1_FilipCica
{
    class Program
    {
		
		static void Main(string[] args)
        {

			Description description = new Description(1, TimeSpan.FromMinutes(45), "Pilot");
			Console.WriteLine(description);
			Episode episode = new Episode(10, 88.64, 9.78, description);
			Console.WriteLine(episode);

			// Assume that the number of rows in the text file is always at least 10. 
			// Assume a valid input file.
			string fileName = "shows.txt";
			string[] episodesInputs = File.ReadAllLines(fileName);
			Episode[] episodes = new Episode[episodesInputs.Length];
			for (int i = 0; i < episodes.Length; i++)
			{
				episodes[i] = TvUtilities.Parse(episodesInputs[i]);
			}
			Console.WriteLine("Episodes:");
			Console.WriteLine(string.Join<Episode>(Environment.NewLine, episodes));
			TvUtilities.Sort(episodes);
			Console.WriteLine("Sorted episodes:");
			string sortedEpisodesOutput = string.Join<Episode>(Environment.NewLine, episodes);
			Console.WriteLine(sortedEpisodesOutput);

			/*for(int i=0;i<3;i++)
				{
					Console.WriteLine(episodesInputs[i]);
				}*/


			/*Episode ep1, ep2;
			ep1 = new Episode();
			ep2 = new Episode(10, 64.32, 8.7);
			int viewers = 10;
			for (int i = 0; i < viewers; i++)
			{
				ep1.AddView(GenerateRandomScore());
				Console.WriteLine($"{i+1}.        { ep1.GetMaxScore()}");
			}
			if (ep1.GetAverageScore() > ep2.GetAverageScore())
			{
				Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
			}
			else
			{
				Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
			}*/
		}
    }
}
