namespace DSA.StacksAndQueues.Interfaces;

/// <summary>
/// Interface of queue.
/// </summary>
public interface IQueueItem
{
    /// <summary>
    /// Adds an item to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
    void Enqueue(int value);

    /// <summary>
    /// Removes and returns the item from the front of the queue.
    /// </summary>
    /// <returns>The item that was removed from the queue.</returns>
    int Dequeue();

    /// <summary>
    /// Returns the item at the front of the queue without removing it.
    /// </summary>
    /// <returns>The item at the front of the queue.</returns>
    int Peek();

    /// <summary>
    /// Checks if the queue is empty.
    /// </summary>
    /// <returns>True if the queue is empty, otherwise false.</returns>
    bool IsEmpty();

    /// <summary>
    /// Returns the number of items in the queue.
    /// </summary>
    /// <returns>The number of items in the queue.</returns>
    int Size();
}
