// See https://aka.ms/new-console-template for more information

using Algorithms.Sorting;

var random = new Random();
var values = new int[1000];

for (int i = 0; i < 1000; i++)
    values[i] = random.Next(3400);

// Insertion Sort
var insertionSortResult = InsertionSort.Sort(values);
var selectionSortResult = SelectionSort.Sort(values);