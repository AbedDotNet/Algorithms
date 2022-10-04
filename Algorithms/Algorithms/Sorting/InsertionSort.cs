namespace Algorithms.Sorting;

using System.Diagnostics;

internal static class InsertionSort
{
    public static int[] Sort(int[] values)
    {
        var watch = Stopwatch.StartNew();

        for (int i = 0; i < values.Length; i++)
        {
            var position = i;
            var tempValue = values[position];

            while (position > 0 && values[position - 1] > tempValue)
            {
                values[position] = values[position - 1];
                position--;
            }

            values[position] = tempValue;
        }

        watch.Stop();

        Console.WriteLine($"It took {watch.Elapsed.TotalMilliseconds} seconds to finish {nameof(InsertionSort)}-{nameof(Sort)}");
        Console.WriteLine();

        foreach (var val in values)
            Console.Write($"{val},");

        return values;
    }
}
