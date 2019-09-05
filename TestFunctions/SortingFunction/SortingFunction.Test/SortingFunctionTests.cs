using System.Collections.Generic;
using System.Linq;
using SortingFunction.Lib;
using NUnit.Framework;

namespace SortingFunction.Test
{
    [TestFixture]
    public class SortingFunctionTests
    {
        [Test, TestCaseSource(typeof(Scenarios), nameof(Scenarios.ExpectedIndexesForPositiveTests))]
        public static void SortingFunctionPositiveTest(SortingFunctionTestCaseData caseData)
        {
            Assert.That(FindFunction.FindIndexes(caseData.Numbers, caseData.Target), Is.Not.Empty, 
                () => "No hits with current values!");
            Assert.That(FindFunction.FindIndexes(caseData.Numbers, caseData.Target).ElementAt(caseData.IndexData),
                Is.EqualTo(caseData.ExpectedIndex));
        }
        [Test, TestCaseSource(typeof(Scenarios), nameof(Scenarios.ExpectedIndexesForNegativeTests))]
        public static void SortingFunctionNegativeTest(SortingFunctionTestCaseData caseData)
        {   
            Assert.That(FindFunction.FindIndexes(caseData.Numbers, caseData.Target), Is.Not.Empty);
            Assert.That(FindFunction.FindIndexes(caseData.Numbers, caseData.Target).ElementAt(caseData.IndexData),
                Is.Not.EqualTo(caseData.ExpectedIndex));
        }
    }
}