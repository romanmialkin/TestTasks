using System;

namespace SortingFunction.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar = new[] { 1, 5, 12, 4 }; //make a class for data input?
            Presenter.PresentIndexes(ar, 10);
            Console.WriteLine();
        }
    }
}
