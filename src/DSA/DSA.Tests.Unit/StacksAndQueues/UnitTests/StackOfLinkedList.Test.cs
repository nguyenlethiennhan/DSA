using DSA.LinkedLists.Interfaces;
using DSA.LinkedLists.Nodes;
using DSA.StacksAndQueues.Implementations;
using Moq;
using Xunit;

namespace DSA.Tests.Unit.StacksAndQueues.UnitTests;

/// <summary>
/// Stack of linked list unit test.
/// </summary>
public class StackOfLinkedListTest
{
    private readonly Mock<ILinkedListOperations> _mockLinkedListOperations;

    public StackOfLinkedListTest()
    {
        _mockLinkedListOperations = new Mock<ILinkedListOperations>();
    }

    [Fact]
    public void Push_Correct()
    {
        // Arrange
        int value = 10;
        _ = _mockLinkedListOperations.Setup(op => op.InsertFirst(It.IsAny<Node?>(), value))
                                 .Returns(new Node(value));
        StackOfLinkedList stack = new(_mockLinkedListOperations.Object);

        // Act
        stack.Push(value);

        // Assert
        _mockLinkedListOperations.Verify(op => op.InsertFirst(It.IsAny<Node?>(), value), Times.Once);
        Assert.Equal(value, stack.Peek());
        Assert.Equal(1, stack.Size());
    }

    [Fact]
    public void Pop_Correct()
    {
        // Arrange
        int value = 10;
        Node node = new(value);
        _ = _mockLinkedListOperations.Setup(op => op.InsertFirst(It.IsAny<Node?>(), value))
                                 .Returns(node);
        _ = _mockLinkedListOperations.Setup(op => op.Count(It.IsAny<Node?>())).Returns(1);
        StackOfLinkedList stack = new(_mockLinkedListOperations.Object);

        // Act
        stack.Push(value);
        int poppedValue = stack.Pop();

        // Assert
        Assert.Equal(poppedValue, value);
        Assert.True(stack.IsEmpty());
    }
}
