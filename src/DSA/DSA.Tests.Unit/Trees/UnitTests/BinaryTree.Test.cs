using DSA.Trees.Implementations;
using DSA.Trees.Nodes;
using System.Collections.Generic;
using Xunit;

namespace DSA.Tests.Unit.Trees.UnitTests;

/// <summary>
/// Binary tree unit test.
/// </summary>
public class BinaryTreeTest
{
    private readonly BinaryTree<char> _tree;

    public BinaryTreeTest()
    {
        TreeNode<char> root = new('R');
        TreeNode<char> nodeA = new('A');
        TreeNode<char> nodeB = new('B');
        TreeNode<char> nodeC = new('C');
        TreeNode<char> nodeD = new('D');
        TreeNode<char> nodeE = new('E');
        TreeNode<char> nodeF = new('F');
        TreeNode<char> nodeG = new('G');

        nodeF.Left = nodeG;

        nodeB.Left = nodeE;
        nodeB.Right = nodeF;

        nodeA.Left = nodeC;
        nodeA.Right = nodeD;

        root.Left = nodeA;
        root.Right = nodeB;

        _tree = new()
        {
            root = root,
        };
    }

    [Fact]
    public void PreOrderTraversal_Correct()
    {
        // Arrange
        List<char> expectedResult = ['R', 'A', 'C', 'D', 'B', 'E', 'F', 'G'];

        // Act
        List<char> result = _tree.PreOrderTraversal();

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void InOrderTraversal_Correct()
    {
        // Arrange
        List<char> expectedResult = ['C', 'A', 'D', 'R', 'E', 'B', 'G', 'F'];

        // Act
        List<char> result = _tree.InOrderTraversal();

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void PostOrderTraversal_Correct()
    {
        // Arrange
        List<char> expectedResult = ['C', 'D', 'A', 'E', 'G', 'F', 'B', 'R'];

        // Act
        List<char> result = _tree.PostOrderTraversal();

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
