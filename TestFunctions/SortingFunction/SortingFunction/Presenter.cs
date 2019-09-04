using System;
using System.Linq;

namespace SortingFunction
{
    public static class Presenter
    {
        public static void PresentIndexes(int[] valueArray, int target)
        {
            var indexes = FindFunction.FindIndexes(valueArray, target);

            if (indexes.Any())
                foreach (var index in indexes)
                {
                    if (index != null)
                        for (int i = 0; i < index.Length; i++)
                            Console.WriteLine($"{index[i]}");
                    else
                        throw new NullReferenceException();
                }
            else
                Console.WriteLine("No hits with current values!");
        }
    }
}
