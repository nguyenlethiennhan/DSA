namespace DSA.LinkedLists.Nodes;

/// <summary>
/// Node of linked list.
/// </summary>
public class Node(int data)
{
    public int Data = data;

    public Node? Next;

    public Node? Prev;
}
