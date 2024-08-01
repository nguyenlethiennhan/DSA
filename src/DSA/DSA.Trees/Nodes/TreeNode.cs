namespace DSA.Trees.Nodes;

/// <summary>
/// Tree node.
/// </summary>
public class TreeNode<T>(T data)
{
    /// <summary>
    /// Data
    /// </summary>
    public T Data = data;

    /// <summary>
    /// Left child node.
    /// </summary>
    public TreeNode<T>? Left;

    /// <summary>
    /// Right child node.
    /// </summary>
    public TreeNode<T>? Right;
}
