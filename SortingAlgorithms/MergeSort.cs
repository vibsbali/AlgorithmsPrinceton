using System;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] items) where T :IComparable<T>
        {
            if (items == null || items.Length == 0)
            {
                throw new ArgumentException("Illegal array passed");
            }

            SplitAndSort(items);
        }

        private static void SplitAndSort<T>(T[] items) where T : IComparable<T>
        {
            var mid = items.Length / 2;
            var leftArray = new T[mid];
            Array.Copy(items, 0, leftArray, 0, mid);

            var rightLength = items.Length - mid;
            var rightArray = new T[rightLength];
            Array.Copy(items, mid, rightArray, 0, rightLength);

            if (leftArray.Length > 1)
            {
                SplitAndSort(leftArray);
            }
            if (rightArray.Length > 1)
            {
                SplitAndSort(rightArray);
            }
            SortAndMerge(leftArray, rightArray, items);
        }

        private static void SortAndMerge<T>(T[] leftArray, T[] rightArray, T[] items) where T : IComparable<T>
        {

            int i = 0, k = 0, j = 0;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    items[k] = leftArray[i];
                    i++;
                    k++;
                }
                else
                {
                    items[k] = rightArray[j];
                    j++;
                    k++;
                }
            }

            while (i < leftArray.Length)
            {
                items[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightArray.Length)
            {
                items[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
