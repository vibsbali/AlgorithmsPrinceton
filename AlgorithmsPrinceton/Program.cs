using System;
using SearchingAlgorithms;

namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main()
        {

            var array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var searchAlgorithms = new BinarySearch<int>();

            var result = searchAlgorithms.Search(array, 11);

            Console.WriteLine(result);
        }
    }
}
