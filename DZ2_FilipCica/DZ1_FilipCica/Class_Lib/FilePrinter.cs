using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Class_Lib
{
    public class FilePrinter:IPrinter
    {
        string filename;
        public FilePrinter(string filename)
        {
            this.filename = filename;
        }

        public void Print(string data)
        {
            
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(data);
            }
        }
    }
}
