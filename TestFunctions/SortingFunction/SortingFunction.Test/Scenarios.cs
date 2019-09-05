using System;
using System.Collections.Generic;
using System.Text;

namespace SortingFunction.Test
{
    public static class Scenarios
    {
        public static IEnumerable<SortingFunctionTestCaseData> ExpectedIndexesForPositiveTests
        {
            get
            {
                yield return new SortingFunctionTestCaseData(new[] { 0, 3 }, 0, new[] { 9, 4, 6, 1 }, 10);
                yield return new SortingFunctionTestCaseData(new[] { 1, 2 }, 1, new[] { 9, 4, 6, 1 }, 10);
                yield return new SortingFunctionTestCaseData(new[] { 0, 1 }, 0, new[] { 1, 0, 0, 1 }, 1);
                yield return new SortingFunctionTestCaseData(new[] { 0, 2 }, 1, new[] { 1, 0, 0, 1 }, 1);
                yield return new SortingFunctionTestCaseData(new[] { 0, 3 }, 0, new[] { 1, 0, 0, 1 }, 2);
                yield return new SortingFunctionTestCaseData(new[] { 0, 3 }, 0, new[] { -1, 0, 0, -1 }, -2);
                yield return new SortingFunctionTestCaseData(new[] { 1, 3 }, 0, new[] { 0, 2, 2, 1 }, 3);
                yield return new SortingFunctionTestCaseData(new[] { 1, 3 }, 0, new[] { 1, 5, 12, 5 }, 10);
                yield return new SortingFunctionTestCaseData(new[] { 1, 2 }, 0, new[] { 1, 5, 12, 4 }, 10);
            }
        }
        public static IEnumerable<SortingFunctionTestCaseData> ExpectedIndexesForNegativeTests
        {
            get
            {
                yield return new SortingFunctionTestCaseData(new[] { 1, 2 }, 0, new[] { 1, 5, 12, 5 }, 10);
            }
        }
    }
}
