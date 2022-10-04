namespace Algorithms.Sorting;

using System.Diagnostics;

internal static class SelectionSort
{
    public static int[] Sort(int[] values)
    {
        var watch = Stopwatch.StartNew();

        for (int i = 0; i < values.Length; i++)
        {
            int lowestValueIndex = i;

            for (int j = i + 1; j < values.Length; j++)
            {
                if (values[j] < values[lowestValueIndex])
                    lowestValueIndex = j;
            }

            if (lowestValueIndex != i)
            {
                var tempValue = values[i];
                values[i] = values[lowestValueIndex];
                values[lowestValueIndex] = tempValue;
            }
        }

        watch.Stop();

        Console.WriteLine($"It took {watch.Elapsed.TotalMilliseconds} seconds to finish {nameof(SelectionSort)}-{nameof(Sort)}");
        Console.WriteLine();

        foreach (var val in values)
            Console.Write($"{val},");

        return values;
    }
}
