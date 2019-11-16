using System;
using System.Linq;

namespace _6kyu
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var value = n.ToString()
                         .Select(c => int.Parse(c.ToString()))
                         .Select((d, indexer) => Math.Pow(d, indexer + p))
                         .Sum();

            return value % n == 0 ? (int)value/n : -1;
        }
    }
}
