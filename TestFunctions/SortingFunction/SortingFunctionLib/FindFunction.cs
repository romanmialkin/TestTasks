using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace SortingFunction.Lib
{
    public static class FindFunction
    {
        [Pure]
        public static IEnumerable<int[]> FindIndexes(int[] nums, int target)
        {
            if (nums.First() == nums.Last() && nums.First() + nums.Last() == target)
                yield return new[] { 0, nums.Length - 1 };

            var newNums = nums.Select((n, k) => Tuple.Create(n, k)).OrderBy(t => t.Item1).ToList();

            var vc = new ValueComparer();

            for (var i = 0; i < newNums.Count; i++)
            {
                var firstValue = newNums[i].Item1;
                var index = newNums.BinarySearch(new Tuple<int, int>(target - firstValue, i), vc);
                if (index > 0  && firstValue == newNums[index].Item1)
                {
                    var nextIndex = i + 1;
                    if (nextIndex < newNums.Count && newNums[i].Item1 == newNums[nextIndex].Item1)
                    {
                        var firstIndex = newNums[i].Item2;
                        var secondIndex = newNums[nextIndex].Item2;
                        yield return firstIndex > secondIndex 
                            ? new[] {secondIndex, firstIndex}
                            : new[] {firstIndex, secondIndex};
                    }
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
