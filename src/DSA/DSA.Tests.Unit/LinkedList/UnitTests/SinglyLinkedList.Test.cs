using DSA.LinkedLists.Implementations;
using DSA.LinkedLists.Nodes;
using DSA.Tests.Unit.Helpers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DSA.Tests.Unit.LinkedList.UnitTests;

/// <summary>
/// Singly linked list unit test.
/// </summary>
public class SinglyLinkedListTest
{
    [Theory]
    [MemberData(nameof(RandomHelpers.GetRandomData), MemberType = typeof(RandomHelpers))]
    public void InsertFirst_Correct(int[] values)
    {
        // arrange
        SinglyLinkedList linkedList = new();
        Node? head = null;

        // act
        foreach (int value in values)
        {
            head = linkedList.InsertFirst(head, value);
        }

        // assert
        Node? current = head;
        for (int i = values.Length - 1; i >= 0; i--)
        {
            Assert.NotNull(current);
            Assert.Equal(values[i], current.Data);
            current = current.Next;
        }

        Assert.Null(current);
    }

    [Fact]
    public void InsertLast_Correct()
    {
        // arrange
        int[] values = RandomHelpers.GenerateRandomArray(100, -999999, 999999);
        SinglyLinkedList linkedList = new();
        Node? head = null;

        // act
        foreach (int value in values)
        {
            head = linkedList.InsertLast(head, value);
        }

        // assert
        Node? current = head;
        for (int i = 0; i < values.Length; i++)
        {
            Assert.NotNull(current);
            Assert.Equal(values[i], current.Data);
            current = current.Next;
        }

        Assert.Null(current);
    }

    [Theory]
    [MemberData(nameof(RandomHelpers.GetRandomData), MemberType = typeof(RandomHelpers))]
    public void TraverseToList_Correct(int[] values)
    {
        // arrange
        SinglyLinkedList linkedList = new();
        Node? head = GenerateLinkedListFromArray(values); // insert first

        // act
        List<int> resultList = linkedList.TraverseToList(head);

        // assert
        Assert.Equal(resultList.Count, values.Length);
        for (int i = values.Length - 1; i >= 0; i--)
        {
            Assert.Equal(resultList[resultList.Count - i - 1], values[i]);
        }
    }

    [Theory]
    [MemberData(nameof(RandomHelpers.GetRandomData), MemberType = typeof(RandomHelpers))]
    public void FindLowestValue_Correct(int[] values)
    {
        // arrange
        SinglyLinkedList linkedList = new();
        Node? head = GenerateLinkedListFromArray(values);
        int expectedResult = values.Min();

        // act
        int result = linkedList.FindLowestValue(head);

        // assert
        Assert.Equal(expectedResult, result);
    }

    /// <summary>
    /// Creates a linked list from an array of integers by inserting elements at the beginning of the list.
    /// </summary>
    /// <param name="values">An array of integers to be inserted into the linked list.</param>
    /// <returns>The head node of the newly created linked list.</returns>
    private static Node? GenerateLinkedListFromArray(int[] values)
    {
        SinglyLinkedList linkedList = new();
        Node? head = null;
        foreach (int value in values)
        {
            head = linkedList.InsertFirst(head, value);
        }
        return head;
    }
}
