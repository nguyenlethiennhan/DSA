using DSA.Trees.Implementations;
using System.Collections.Generic;
using Xunit;

namespace DSA.Tests.Unit.Trees.UnitTests;

/// <summary>
/// Binary tree array unit test.
/// </summary>
public class BinaryTreeArrayTest
{
    [Fact]
    public void PreOrderTraversal_Correct()
    {
        // Arrange
        List<char?> treeData = ['R', 'A', 'B', 'C', 'D', 'E', 'F', null, null, null, null, null, null, 'G'];
        List<char?> expectedResult = ['R', 'A', 'C', 'D', 'B', 'E', 'F', 'G'];
        BinaryTreeArray<char?> tree = new(4);
        tree.SetData(treeData);

        // Act
        List<char?> result = tree.PreOrderTraversal();

        // Assert;
        Assert.Equal(expectedResult, result);
    }
}
