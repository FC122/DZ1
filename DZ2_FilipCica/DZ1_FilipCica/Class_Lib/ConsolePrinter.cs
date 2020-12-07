using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Class_Lib
{
    public class ConsolePrinter:IPrinter
    {
        public void Print(string line)
        {
            Console.WriteLine(line);
        }
    }
}
