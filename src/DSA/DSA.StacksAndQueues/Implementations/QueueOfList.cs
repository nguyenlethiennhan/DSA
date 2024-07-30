using DSA.StacksAndQueues.Interfaces;

namespace DSA.StacksAndQueues.Implementations;

/// <summary>
/// Queue of list.
/// </summary>
public class QueueOfList : IQueueItem
{
    private readonly List<int> _queue = [];

    public int Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        int value = _queue[0];
        _queue.RemoveAt(0);
        return value;
    }

    public void Enqueue(int value)
    {
        _queue.Add(value);
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public int Peek()
    {
        return _queue.Count == 0 ? throw new InvalidOperationException("The stack is empty.") : _queue[0];
    }

    public int Size()
    {
        return _queue.Count;
    }
}
