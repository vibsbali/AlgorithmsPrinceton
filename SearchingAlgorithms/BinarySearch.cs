using System;

namespace SearchingAlgorithms
{
    public class BinarySearch<T> where T : IComparable<T>
    {
        public bool Search(T[] items, T value)
        {
            var low = 0;
            var hi = items.Length - 1;

            while (low <= hi)
            {
                var mid = (hi - low) / 2 + low;

                if (items[mid].CompareTo(value) == 0)
                {
                    return true;
                }

                if (items[mid].CompareTo(value) > 0)
                {
                    hi = mid - 1; //substract - 1 because mid is already checked
                }
                else
                {
                    low = mid + 1; //Add + 1 because mid is already checked
                }

            }

            return false;
        }
    }
}
