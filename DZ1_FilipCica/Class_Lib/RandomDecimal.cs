using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Lib
{
    public class RandomDecimal
    {
        Random RandomNumber = new Random();

        public decimal GetRandomDecimal()
        {
            int I;
            int D;
            decimal d;
            I=RandomNumber.Next(1,10);
            if (I == 10) { return 10; }
            D = RandomNumber.Next(0,999);
            d = D /(decimal)1000;
           // Console.WriteLine(d);
            I = I % 10;
            //Console.WriteLine(I+d);
            return (I + d);

        }
    }
}
