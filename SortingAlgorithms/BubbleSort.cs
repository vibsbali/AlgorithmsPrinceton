using System;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] items) where T : IComparable<T>
        {
            bool hasSwapBeenPerformed;
            do
            {
                hasSwapBeenPerformed = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        hasSwapBeenPerformed = true;
                    }
                }
            } while (hasSwapBeenPerformed);
        }

        private static void Swap<T>(T[] items, int i, int i1)
        {
            var temp = items[i];
            items[i] = items[i1];
            items[i1] = temp;
        }
    }
}
