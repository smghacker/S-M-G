﻿using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null,"There is no array");
        Debug.Assert(arr.Length > 0,"There are no elements in the array");

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        for (int index = 0; index < arr.Length - 1; index++)
        {
            Debug.Assert(arr[index].CompareTo(arr[index+1]) <= 0, "The SelectionSort doesn't work");
        }
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null,"There is no array");
        Debug.Assert(arr.Length > 0,"There are no elements in the array");
        Debug.Assert(startIndex >= 0,"Start Index must be positive");
        Debug.Assert(startIndex < arr.Length, "Start Index is out of bounds of the array");
        Debug.Assert(endIndex >= startIndex, "End Index must be bigger of Start Index");
        Debug.Assert(endIndex < arr.Length, "End Index is out of bounds of the array");
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[minElementIndex]) >= 0, "FindMinElementIndex doesn't work");
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null, "Swap takes non-nullable arguments");
        Debug.Assert(y != null, "Swap takes non-nullable arguments");
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null);
        Debug.Assert(arr.Length > 0);
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null);
        Debug.Assert(arr.Length > 0);
        Debug.Assert(startIndex >= 0);
        Debug.Assert(startIndex < arr.Length);
        Debug.Assert(endIndex >= startIndex);
        Debug.Assert(endIndex < arr.Length);
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }
        
        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
