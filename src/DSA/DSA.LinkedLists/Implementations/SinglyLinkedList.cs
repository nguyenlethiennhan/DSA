using DSA.LinkedLists.Interfaces;
using DSA.LinkedLists.Nodes;

namespace DSA.LinkedLists.Implementations;

/// <summary>
/// Singly linked list.
/// </summary>
public class SinglyLinkedList : ILinkedListOperations
{
    /// <inheritdoc/>
    public Node? DeleteSpecificValue(Node? head, int value)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int FindLowestValue(Node? head)
    {
        ArgumentNullException.ThrowIfNull(head);
        int minValue = int.MaxValue;
        for (Node? node = head; node != null; node = node.Next)
        {
            minValue = Math.Min(minValue, node.Data);
        }
        return minValue;
    }

    /// <inheritdoc/>
    public Node? InsertAtPosition(Node? head, int value, int position)
    {
        // TODO
        ArgumentOutOfRangeException.ThrowIfNegative(position);
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Node? InsertFirst(Node? head, int value)
    {
        return new Node(value) { Next = head };
    }

    /// <inheritdoc/>
    public Node? InsertLast(Node? head, int value)
    {
        Node newNode = new(value);

        if (head == null)
        {
            return newNode;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
        return head;
    }

    /// <inheritdoc/>
    public List<int> TraverseToList(Node? head)
    {
        List<int> list = [];
        for (Node? node = head; node != null; node = node.Next)
        {
            list.Add(node.Data);
        }
        return list;
    }
}
