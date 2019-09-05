using System;
using System.Linq;
using SortingFunction.Lib;

namespace SortingFunction.ConsoleApp
{
    public static class Presenter
    {
        public static void PresentIndexes(int[] valueArray, int target)
        {
            var indexes = FindFunction.FindIndexes(valueArray, target).ToList();

            if (indexes.Any())
                foreach (var index in indexes)
                {
                    if (index != null)
                        foreach (var i in index)
                            Console.WriteLine($"{i}");
                    else
                        throw new NullReferenceException();
                }
            else
                Console.WriteLine("No hits with current values!");
        }
    }
}
