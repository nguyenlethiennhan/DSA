using DSA.LinkedLists.Interfaces;
using DSA.LinkedLists.Nodes;
using DSA.StacksAndQueues.Interfaces;

namespace DSA.StacksAndQueues.Implementations;

/// <summary>
/// Stack of linked list.
/// </summary>
public class StackOfLinkedList : IStackItem
{
    private Node? _stack;

    private int _size;

    private readonly ILinkedListOperations _linkedListOperations;

    /// <summary>
    /// Constructor.
    /// </summary>
    public StackOfLinkedList(ILinkedListOperations linkedListOperations)
    {
        _linkedListOperations = linkedListOperations;
        _size = 0;
    }

    /// <inheritdoc/>
    public bool IsEmpty()
    {
        return _size == 0;
    }

    /// <inheritdoc/>
    public int Peek()
    {
        return _size == 0 ? throw new InvalidOperationException("The stack is empty.") : _stack!.Data;
    }

    /// <inheritdoc/>
    public int Pop()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        int value = _stack!.Data;
        _stack = _stack.Next;
        _size -= 1;
        return value;
    }

    /// <inheritdoc/>
    public void Push(int value)
    {
        _stack = _linkedListOperations.InsertFirst(_stack, value);
        _size += 1;
    }

    /// <inheritdoc/>
    public int Size()
    {
        return _size;
    }
}
