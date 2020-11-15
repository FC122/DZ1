using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Lib
{
    public static class RandomScore
    {
       // Random RandomNumber = new Random();

        public static decimal GenerateRandomScore()
        {
            Random RandomNumber = new Random();
            int I;
            int D;
            decimal d;
            I=RandomNumber.Next(1,10);
            if (I == 10) { return 100; }
            D = RandomNumber.Next(0,999);
            d = D /(decimal)1000;
           // Console.WriteLine(d);
            I = I % 10;
            //Console.WriteLine(I+d);
            return (I + d);

        }
    }
}
