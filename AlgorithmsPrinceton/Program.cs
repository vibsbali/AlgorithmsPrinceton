using System;
using SortingAlgorithms;

namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main()
        {
           

            var array = new[] {5, 2, 5, 66, 10, 32, 22, 0};
            InsertionSort.Sort(array);

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
