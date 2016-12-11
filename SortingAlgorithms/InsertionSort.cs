using System;

namespace SortingAlgorithms
{
    /// <summary>
    /// Insertion sort works by finding the minimum item and bringing to front
    /// However, unlike selection sort it only checks if the previous item is greater and stop 
    /// as soon as smaller value is found
    /// The average case complexity is O(N^2) / 4
    /// </summary>
    public static class InsertionSort
    {
        public static void Sort<T>(T[] items) where T : IComparable<T>
        {
            for (int i = 0; i < items.Length; i++)
            {
                //The first value considered sorted
                for (int j = i; j >0; j--)
                {
                    if (items[j].CompareTo(items[j - 1]) < 0)
                    {
                        Swap(items, j, j-1);
                    }
                    else
                    {
                        break;
                    }
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
