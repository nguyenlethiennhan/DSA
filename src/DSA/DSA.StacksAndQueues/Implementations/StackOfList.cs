using DSA.StacksAndQueues.Interfaces;

namespace DSA.StacksAndQueues.Implementations;

/// <summary>
/// Stack of list.
/// </summary>
public class StackOfList : IStackItem
{
    private readonly List<int> _stack = [];

    /// <inheritdoc/>
    public bool IsEmpty()
    {
        return _stack.Count == 0;
    }

    /// <inheritdoc/>
    public int Peek()
    {
        return _stack.Count == 0 ? throw new InvalidOperationException("The stack is empty.") : _stack[^1];
    }

    /// <inheritdoc/>
    public int Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        int value = _stack[^1];
        _stack.RemoveAt(_stack.Count - 1);
        return value;
    }

    /// <inheritdoc/>
    public void Push(int value)
    {
        _stack.Add(value);
    }

    /// <inheritdoc/>
    public int Size()
    {
        return _stack.Count;
    }
}
