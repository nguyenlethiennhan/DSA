using DSA.Tests.Unit.Helpers;
using DSA.Tests.Unit.SortAlogorithms.Models;
using System.Collections.Generic;
using Xunit;

namespace DSA.Tests.Unit.SortAlgorithms.UnitTests;

/// <summary>
/// Sort algorithms unit test
/// </summary>
public class SortAlgorithmsTest
{
    private List<SortAlgorithmsTestCase>? testCases;
    private const string DATA_PATH = "/SortAlgorithms/Data/sort-algorithms-data.json";

    [Fact]
    public void Setup()
    {
        testCases ??= JsonExtensions.LoadData<List<SortAlgorithmsTestCase>>(DATA_PATH);
    }

    [Fact]
    public void BubbleSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            List<int> input = new(testCase.Input);
            DSA.SortAlgorithms.SortAlgorithms.BubbleSort(input);
            Assert.Equal(testCase.ExpectedOutput, input);
        }
    }

    [Fact]
    public void SelectionSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            List<int> input = new(testCase.Input);
            DSA.SortAlgorithms.SortAlgorithms.SelectionSort(input);
            Assert.Equal(testCase.ExpectedOutput, input);
        }
    }

    [Fact]
    public void InsertionSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            List<int> input = new(testCase.Input);
            DSA.SortAlgorithms.SortAlgorithms.InsertionSort(input);
            Assert.Equal(testCase.ExpectedOutput, input);
        }
    }

    [Fact]
    public void QuickSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            List<int> input = new(testCase.Input);
            DSA.SortAlgorithms.SortAlgorithms.QuickSort(input);
            Assert.Equal(testCase.ExpectedOutput, input);
        }
    }

    [Fact]
    public void CountingSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            if (!testCase.Description.Contains("negative") && testCase.Input.Count > 0)
            {
                List<int> input = new(testCase.Input);
                DSA.SortAlgorithms.SortAlgorithms.CountingSort(input);
                Assert.Equal(testCase.ExpectedOutput, input);
            }
        }
    }

    [Fact]
    public void RadixSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            if (!testCase.Description.Contains("negative") && testCase.Input.Count > 0)
            {
                List<int> input = new(testCase.Input);
                DSA.SortAlgorithms.SortAlgorithms.RadixSort(input);
                Assert.Equal(testCase.ExpectedOutput, input);
            }
        }
    }

    [Fact]
    public void MergeSort_Correct()
    {
        // arrange
        Setup();

        // act & assert
        foreach (SortAlgorithmsTestCase testCase in testCases!)
        {
            List<int> input = new(testCase.Input);
            DSA.SortAlgorithms.SortAlgorithms.MergeSort(input);
            Assert.Equal(testCase.ExpectedOutput, input);
        }
    }
}
