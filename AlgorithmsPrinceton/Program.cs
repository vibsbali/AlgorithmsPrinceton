using System;
using System.Linq;
using SortingAlgorithms;

namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main()
        {
            var range = Enumerable.Range(1, 123).ToArray();

            var random = new Random();

            for (int i = 0; i < range.Length; i++)
            {
                var firstIndex = random.Next(0, 122);
                var secondIndex = random.Next(0, 122);

                Swap(range, firstIndex, secondIndex);
            }

            var array = range.ToArray();
            MergeSort.Sort(array);

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        private static void Swap(int[] range, int firstIndex, int secondIndex)
        {
            var temp = range[secondIndex];
            range[secondIndex] = range[firstIndex];
            range[firstIndex] = temp;
        }
    }
}
