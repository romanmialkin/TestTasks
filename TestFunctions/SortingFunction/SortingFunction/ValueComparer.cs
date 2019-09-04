using System;
using System.Collections.Generic;

namespace SortingFunction
{
    public class ValueComparer : IComparer<Tuple<int, int>>
    {
        public int Compare(Tuple<int, int> x, Tuple<int, int> y)
        {
            if (x == null)
                return -1;
            if (y == null)
                return -1;
            return x.Item1.CompareTo(y.Item1);
        }
    }
}
