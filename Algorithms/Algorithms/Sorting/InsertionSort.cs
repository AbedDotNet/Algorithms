namespace Algorithms.Sorting;

using System.Diagnostics;

internal static class InsertionSort
{
    public static int[] Sort(int[] unsortedValues)
    {
        var watch = Stopwatch.StartNew();
        var sortedValues = unsortedValues;

        for (int i = 0; i < unsortedValues.Length; i++)
        {
            var position = i;
            var tempValue = unsortedValues[position];

            while (position > 0 && unsortedValues[position - 1] > tempValue)
            {
                unsortedValues[position] = unsortedValues[position - 1];
                position--;
            }

            unsortedValues[position] = tempValue;
        }

        watch.Stop();

        Console.WriteLine($"It took {watch.Elapsed.TotalMilliseconds} seconds to finish {nameof(InsertionSort)}-{nameof(Sort)}");

        return sortedValues;
    }
}
