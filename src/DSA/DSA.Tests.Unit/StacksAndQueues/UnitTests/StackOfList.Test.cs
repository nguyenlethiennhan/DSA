using DSA.StacksAndQueues.Implementations;
using System;
using Xunit;

namespace DSA.Tests.Unit.StacksAndQueues.UnitTests;

/// <summary>
/// Stack of list unit test.
/// </summary>
public class StackOfListTest
{
    [Fact]
    public void Push_Correct()
    {
        // Arrange
        StackOfList stack = new();
        int value = 10;

        // Act
        stack.Push(value);

        // Assert
        Assert.False(stack.IsEmpty());
        Assert.Equal(value, stack.Peek());
    }

    [Fact]
    public void Pop_Correct()
    {
        // Arrange
        StackOfList stack = new();
        stack.Push(10);
        stack.Push(20);

        // Act
        int poppedValue = stack.Pop();

        // Assert
        Assert.Equal(20, poppedValue);
        Assert.Equal(1, stack.Size());
    }

    [Fact]
    public void Pop_ThrowException_WhenStackIsEmpty()
    {
        // Arrange
        StackOfList stack = new();

        // Act & Assert
        _ = Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Peek_Correct()
    {
        // Arrange
        StackOfList stack = new();
        stack.Push(10);
        stack.Push(20);

        // Act
        int topValue = stack.Peek();

        // Assert
        Assert.Equal(20, topValue);
        Assert.Equal(2, stack.Size());
    }

    [Fact]
    public void Peek_ThrowException_WhenStackIsEmpty()
    {
        // Arrange
        StackOfList stack = new();

        // Act & Assert
        _ = Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    [Fact]
    public void IsEmpty_Correct()
    {
        // Arrange
        StackOfList stack1 = new();
        StackOfList stack2 = new();

        // Act & Assert
        stack2.Push(10);
        stack2.Push(20);

        // Assert
        Assert.True(stack1.IsEmpty());
        Assert.False(stack2.IsEmpty());
    }

    [Fact]
    public void Size_Correct()
    {
        // Arrange
        StackOfList stack = new();
        stack.Push(10);
        stack.Push(20);

        // Act
        int size = stack.Size();

        // Assert
        Assert.Equal(2, size);
    }
}
