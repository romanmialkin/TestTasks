namespace SortingFunction.Test
{
    public class SortingFunctionTestCaseData
    {
        public SortingFunctionTestCaseData(int[] expected, int index, int[] numbers, int target)
        {
            ExpectedIndex = expected;
            IndexData = index;
            Numbers = numbers;
            Target = target;
        }
        public int[] ExpectedIndex { get; }
        public int IndexData { get; }
        public int[] Numbers { get; }
        public int Target { get; }
        public override string ToString()
        {
            return $@"Indexes: [{ExpectedIndex[0]}, {ExpectedIndex[1]}], #{IndexData.ToString()}, Target: {Target.ToString()}";
        }
    }
}
