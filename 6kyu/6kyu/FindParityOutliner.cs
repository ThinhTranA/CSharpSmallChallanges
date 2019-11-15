using System;
using System.Linq;

namespace _6kyu
{

    public class FindParityOutliner
    {
        public static int Find(int[] integers)
        {
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }
    }
}
