namespace DSA.Trees.Implementations;

/// <summary>
/// Binary tree array.
/// </summary>
public class BinaryTreeArray<T>(int high)
{
    private readonly List<T?> Tree = new(new T?[(int)Math.Pow(2, high) - 1]);

    public static int GetLeftChildIndex(int index)
    {
        return (2 * index) + 1;
    }

    public static int GetRightChildIndex(int index)
    {
        return (2 * index) + 2;
    }

    public T? GetDataIndex(int index)
    {
        return index >= 0 && index < Tree.Count ? Tree[index] : default;
    }

    public void SetData(List<T?> data)
    {
        if (data.Count > Tree.Count)
        {
            throw new ArgumentException($"Size of tree must be less than or equal to {Tree.Count}");
        }
        for (int i = 0; i < data.Count; i++)
        {
            Tree[i] = data[i];
        }
        for (int i = data.Count; i < Tree.Count; i++)
        {
            Tree[i] = default;
        }
    }

    public List<T?> PreOrderTraversal()
    {
        static void PreOrderTraversal(List<T?> tree, List<T?> traversalList, int index)
        {
            if (index < 0 || index >= tree.Count || tree[index] == null)
            {
                return;
            }
            traversalList.Add(tree[index]);
            PreOrderTraversal(tree, traversalList, GetLeftChildIndex(index));
            PreOrderTraversal(tree, traversalList, GetRightChildIndex(index));
        }

        List<T?> traversalList = [];
        PreOrderTraversal(Tree, traversalList, 0);
        return traversalList;
    }
}
