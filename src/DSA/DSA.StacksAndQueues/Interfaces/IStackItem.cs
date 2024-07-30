namespace DSA.StacksAndQueues.Interfaces;

/// <summary>
/// Interface of stack.
/// </summary>
public interface IStackItem
{
    /// <summary>
    /// Pushes an item onto the stack.
    /// </summary>
    void Push(int value);

    /// <summary>
    /// Removes and returns the top item of the stack.
    /// </summary>
    /// <returns>The item at the top of the stack.</returns>
    int Pop();

    /// <summary>
    /// Returns the top item of the stack without removing it.
    /// </summary>
    /// <returns>The item at the top of the stack.</returns>
    int Peek();

    /// <summary>
    /// Determines whether the stack is empty.
    /// </summary>
    /// <returns>true if the stack is empty; otherwise, false.</returns>
    bool IsEmpty();

    /// <summary>
    /// Gets the number of items in the stack.
    /// </summary>
    /// <returns>The number of items in the stack.</returns>
    int Size();
}