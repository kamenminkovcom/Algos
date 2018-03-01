namespace Algos.Selection
{
    using System;
    using System.Collections.Generic;

    public class SelectionSort
    {
        public void Sort<T>(List<T> collection) where T : IComparable
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                T min = collection[i];
                int minIndex = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(min) < 0)
                    {
                        min = collection[j];
                        minIndex = j;
                    }
                }
                // Swap elements
                T help = collection[i];
                collection[i] = collection[minIndex];
                collection[minIndex] = help;
            }
        }
    }
}
