using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _6kyu
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var digits = n.ToString().Select(digit => digit.ToString()).ToArray();
            int result = 0;
            for(int i = 0; i < digits.Length; i++)
            {
                result = result + (int) Math.Pow(double.Parse(digits[i]), p);
                p++;
            }
            var data = result / n;
            if(result % n ==0)
            {
                return data;
            }


            return -1;
        }
    }
}
