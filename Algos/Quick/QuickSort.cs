namespace Algos.Quick
{
    using System;
    using System.Collections.Generic;

    public class QuickSort
    {
        public void Sort<T>(List<T> collection, int start, int end) where T : IComparable
        {
            if (start >= end)
            {
                return;
            }

            T pivot = collection[start];
            int storeIndex = start + 1;

            for (int i = start + 1; i <= end; i++)
            {
                if (collection[i].CompareTo(pivot) < 0)
                {
                    Swap(collection, i, storeIndex);
                    storeIndex++;
                }
            }

            storeIndex--;

            Swap(collection, storeIndex, start);
            Sort(collection, start, storeIndex - 1);
            Sort(collection, storeIndex + 1, end);
        }

        private void Swap<T>(List<T> array, int a, int b) where T : IComparable
        {
            var help = array[a];
            array[a] = array[b];
            array[b] = help;
        }
    }
}
