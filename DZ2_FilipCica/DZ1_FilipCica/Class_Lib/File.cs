using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Class_Lib
{
    public static class File
    {

        public static string[] ReadAllLines(string filename)
        {
            string[] episodeInputs=new string[10];
            using (StreamReader reader=new StreamReader(filename))
            {
                int current = 0;
                 string line = string.Empty;
                
                 while ((line = reader.ReadLine()) != null)
                     {
                     episodeInputs[current] = line;
                     current++;
                     }
            }
            return episodeInputs;
        }

    }
}
