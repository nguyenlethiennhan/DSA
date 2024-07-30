using DSA.LinkedLists.Nodes;

namespace DSA.LinkedLists.Interfaces;

/// <summary>
/// Interface for common linked list operations.
/// </summary>
public interface ILinkedListOperations
{
    /// <summary>
    /// Traverses the linked list and returns a list of its elements.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    /// <returns>A list of integers representing the linked list elements.</returns>
    List<int> TraverseToList(Node? head);

    /// <summary>
    /// Finds the lowest value in the linked list.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    /// <returns>The lowest integer value in the linked list.</returns>
    int FindLowestValue(Node? head);

    /// <summary>
    /// Deletes the first occurrence of a specific value from the linked list.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    /// <param name="value">The value to delete.</param>
    /// <returns>The head node of the linked list after deletion.</returns>
    Node? DeleteSpecificValue(Node? head, int value);

    /// <summary>
    /// Inserts a new node with the specified value at the beginning of the linked list.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    /// <param name="value">The value to insert.</param>
    /// <returns>The head node of the linked list after insertion.</returns>
    Node? InsertFirst(Node? head, int value);

    /// <summary>
    /// Inserts a new node with the specified value at the end of the linked list.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    /// <param name="value">The value to insert.</param>
    /// <returns>The head node of the linked list after insertion.</returns>
    Node? InsertLast(Node? head, int value);

    /// <summary>
    /// Inserts a new node with the specified value at a given position in the linked list.
    /// </summary>
    /// <param name="head">The head node of the linked list.</param>
    /// <param name="value">The value to insert.</param>
    /// <param name="position">The position at which to insert the new node.</param>
    /// <returns>The head node of the linked list after insertion.</returns>
    Node? InsertAtPosition(Node? head, int value, int position);
}
