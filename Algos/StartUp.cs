namespace Algos
{
    using Algos.Selection;
    using Algos.Quick;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            List<int> numbers = new List<int>{ 1, 5, 2, 3, 1 };
            QuickSort quick = new QuickSort();
            quick.Sort(numbers, 0, numbers.Count - 1);
        }
    }
}
