using System;

namespace SortingAlgorithms
{
    /// <summary>
    /// Selection sort works by finding the minimum item and bringing to front
    /// The average case complexity is O(N^2)/2
    /// </summary>
    public static class SelectionSort
    {
        public static void Sort<T>(T[] items) where T : IComparable<T>
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                var min = i;
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[min].CompareTo(items[j]) > 0)
                    {
                        min = j;
                    }
                }

                if (i != min)
                {
                    Swap(items, i, min);
                }
            }
        }


        private static void Swap<T>(T[] items, int i, int i1)
        {
            var temp = items[i];
            items[i] = items[i1];
            items[i1] = temp;
        }
    }
}
