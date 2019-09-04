using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace SortingFunction
{
    public static class FindFunction
    {
        [Pure]
        public static IEnumerable<int[]> FindIndexes(int[] nums, int target)
        {
            var newNums = nums.Select((n, k) => Tuple.Create(n, k)).OrderBy(t => t.Item1).ToList();

            var vc = new ValueComparer();

            for (int i = 0; i < newNums.Count; i++)
            {
                var firstValue = newNums[i].Item1;

                var index = newNums.BinarySearch(new Tuple<int, int>(target - firstValue, 0), vc);

                if (index > 0 && firstValue == newNums[index].Item1)
                {
                    var firstIndex = newNums[i].Item2;
                    var secondIndex = newNums[i + 1].Item2;
                    if (newNums[i].Item1 + newNums[i + 1].Item1 == target)
                        yield return firstIndex > secondIndex ? new[] { secondIndex, firstIndex }
                        : new[] { firstIndex, secondIndex };
                }

                if (index > 0 && firstValue < newNums[index].Item1)
                {
                    var firstIndex = newNums[i].Item2;
                    var secondIndex = newNums[index].Item2;

                    yield return firstIndex > secondIndex ? new[] { secondIndex, firstIndex }
                        : new[] { firstIndex, secondIndex };

                }
            }
        }
    }
}
