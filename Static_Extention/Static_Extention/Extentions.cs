using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extention
{
    public static class  Extentions
    {
        public static int PowerOfNumbers(this int n, int m)
        {
            double power = Math.Pow(n, m);
            return Convert.ToInt32(power);
        }
    }
}
