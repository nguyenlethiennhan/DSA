using DSA.Tests.Unit.Helpers;
using DSA.Tests.Unit.SearchAlgorithms.Models;
using System.Collections.Generic;
using Xunit;

namespace DSA.Tests.Unit.SearchAlgorithms.UnitTests;

/// <summary>
/// Search algorithms unit test.
/// </summary>
public class SearchAlgorithmsTest
{
    [Fact]
    public void LinearSearch_Correct()
    {
        // arrange
        List<SearchAlgorithmTestCase> testCases = JsonExtensions.LoadData<List<SearchAlgorithmTestCase>>("/SearchAlgorithms/Data/linear-search-algorithms-data.json");

        // act & assert
        testCases.ForEach(testCase =>
        {
            (List<int> array, int target, int? expectedOutput) = (testCase.Input.Array, testCase.Input.Target, testCase.ExpectedOutput);
            int result = DSA.SearchAlgorithms.SearchAlgorithms.LinearSearch(array, target);
            Assert.Equal(expectedOutput, result);
        });
    }

    [Fact]
    public void BinarySearch_Correct()
    {
        // arrange
        List<SearchAlgorithmTestCase> testCases = JsonExtensions.LoadData<List<SearchAlgorithmTestCase>>("/SearchAlgorithms/Data/binary-search-algorithms-data.json");

        // act & assert
        testCases.ForEach(testCase =>
        {
            (List<int> array, int target) = (testCase.Input.Array, testCase.Input.Target);
            int result = DSA.SearchAlgorithms.SearchAlgorithms.BinarySearch(array, target);
            if (testCase.ExpectedOutput == null)
            {
                Assert.Equal(target, array[result]);
            }
            else
            {
                Assert.Equal(-1, result);
            }
        });
    }
}
