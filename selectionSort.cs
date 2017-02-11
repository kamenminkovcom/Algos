using System;

class SelectionSort 
{
    private static int[] collection = new int[] { 1, 5, 1, 3, 5, 10, 10, 100, 199, 45, 51 };

    static void Main()
    {
        for (int i = 0; i < collection.Length - 1; i++)
        {
            int min = collection[i];
            int minIndex = i;
            for (int j = i + 1; j < collection.Length; j++)
            {
                if (collection[j] < min)
                {
                    min = collection[j];
                    minIndex = j;
                }
            }
            // Swap elements
            int help = collection[i];
            collection[i] = collection[minIndex];
            collection[minIndex] = help;
        }
        foreach (var element in collection)
        {
            Console.WriteLine(element);
        }
    }
}

