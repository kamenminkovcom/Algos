using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        var collection = new List<int>();
        var rand = new Random();
        for (int i = 0; i <= 100; i++)
        {
            collection.Add(rand.Next());
        }

        Quicksort(collection, 0, collection.Count - 1);

        foreach (var element in collection)
        {
            Console.WriteLine(element);
        }
    }

    public static void Quicksort(List<int> array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int pivot = array[start];
        int storeIndex = start + 1;

        for (int i = start + 1; i <= end; i++)
        {
            if (array[i] < pivot)
            {
                Swap(array, i, storeIndex);
                storeIndex++;
            }
        }

        storeIndex--;

        Swap(array, storeIndex, start);
        Quicksort(array, start, storeIndex - 1);
        Quicksort(array, storeIndex + 1, end);
    }

    public static void Swap(List<int> array, int a, int b)
    {
        var help = array[a];
        array[a] = array[b];
        array[b] = help;
    }

}

