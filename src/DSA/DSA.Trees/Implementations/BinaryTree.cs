using DSA.Trees.Nodes;

namespace DSA.Trees.Implementations;

/// <summary>
/// Binary tree.
/// </summary>
public class BinaryTree<T>
{
    public TreeNode<T>? root;

    public List<T> PreOrderTraversal()
    {
        static void PreOrderTraversal(List<T> traversalList, TreeNode<T>? root)
        {
            if (root == null)
            {
                return;
            }
            traversalList.Add(root.Data);
            PreOrderTraversal(traversalList, root.Left);
            PreOrderTraversal(traversalList, root.Right);
        }

        List<T> traversalList = [];
        PreOrderTraversal(traversalList, root);
        return traversalList;
    }

    public List<T> InOrderTraversal()
    {
        static void InOrderTraversal(List<T> traversalList, TreeNode<T>? root)
        {
            if (root == null)
            {
                return;
            }
            InOrderTraversal(traversalList, root.Left);
            traversalList.Add(root.Data);
            InOrderTraversal(traversalList, root.Right);
        }

        List<T> traversalList = [];
        InOrderTraversal(traversalList, root);
        return traversalList;
    }

    public List<T> PostOrderTraversal()
    {
        static void PostOrderTraversal(List<T> traveralList, TreeNode<T>? root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderTraversal(traveralList, root.Left);
            PostOrderTraversal(traveralList, root.Right);
            traveralList.Add(root.Data);
        }

        List<T> traveralList = [];
        PostOrderTraversal(traveralList, root);
        return traveralList;
    }
}
