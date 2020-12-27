using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Lib
{
    public class TvException:Exception
    {
        string title;

        public string Title
        {
            get { return title; }
        }
        public TvException(string title,string message):base(message)
        {
            this.title = title;
        }
    }
}
