using DSA.StacksAndQueues.Implementations;
using Xunit;

namespace DSA.Tests.Unit.StacksAndQueues.UnitTests;

/// <summary>
/// Queue of list unit test.
/// </summary>
public class QueueOfListTest
{
    [Fact]
    public void Enqueue_Correct()
    {
        // Arrange
        QueueOfList queue = new();
        (int, int) value = (10, 20);

        // Act
        queue.Enqueue(value.Item1);
        queue.Enqueue(value.Item2);

        // Assert
        Assert.Equal(queue.Dequeue(), value.Item1);
        Assert.Equal(queue.Dequeue(), value.Item2);
        Assert.True(queue.IsEmpty());
    }
}
