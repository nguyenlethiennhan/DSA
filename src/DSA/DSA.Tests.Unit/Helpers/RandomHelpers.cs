using System;
using System.Collections.Generic;

namespace DSA.Tests.Unit.Helpers;

/// <summary>
/// Random extensions.
/// </summary>
public static class RandomHelpers
{
    /// <summary>
    /// Generates an array of random integers.
    /// </summary>
    /// <param name="size">The number of elements in the array.</param>
    /// <param name="minValue">The minimum value (inclusive) for random numbers.</param>
    /// <param name="maxValue">The maximum value (exclusive) for random numbers.</param>
    /// <returns>An array of random integers.</returns>
    public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(minValue, maxValue);
        }
        return array;
    }

    /// <summary>
    /// Provides test data with random integer arrays of varying sizes and ranges.
    /// </summary>
    /// <returns>An enumerable collection of object arrays, each containing a random integer array.</returns>
    public static IEnumerable<object[]> GetRandomData()
    {
        yield return new object[] { RandomHelpers.GenerateRandomArray(9, -99, 99) };
        yield return new object[] { RandomHelpers.GenerateRandomArray(19, -999, 999) };
        yield return new object[] { RandomHelpers.GenerateRandomArray(199, -9999, 9999) };
        yield return new object[] { RandomHelpers.GenerateRandomArray(19999, -99999, 99999) };
        yield return new object[] { RandomHelpers.GenerateRandomArray(199999, -999999, 999999) };
    }
}
