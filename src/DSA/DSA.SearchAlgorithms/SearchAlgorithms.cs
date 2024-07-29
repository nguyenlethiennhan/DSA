namespace DSA.SearchAlgorithms;

/// <summary>
/// Search algorithms.
/// </summary>
public static class SearchAlgorithms
{
    public static int LinearSearch(List<int> list, int target)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    public static int BinarySearch(List<int> list, int target)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (list[mid] == target)
            {
                return mid;
            } 
            else if (list[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
