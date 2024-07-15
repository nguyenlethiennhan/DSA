namespace DSA.SortAlgorithms;

public static class SortAlgorithms
{
    public static void BubbleSort(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
    }

    public static void SelectionSort(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    (list[i], list[j]) = (list[j], list[i]);
                }
            }
        }
    }

    public static void InsertionSort(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
                else
                {
                    break;
                }
            }
        }
    }

    public static void QuickSort(List<int> list, int start = 0, int? end = null)
    {
        end ??= list.Count - 1;

        if (start < end)
        {
            int pivotIndex = start;
            for (int i = start; i <= end; i++)
            {
                if (i < pivotIndex && list[i] > list[pivotIndex])
                {
                    (list[i], list[pivotIndex]) = (list[pivotIndex], list[i]);
                    pivotIndex = i;
                } 
                else if (i > pivotIndex && list[i] < list[pivotIndex])
                {
                    (list[i], list[pivotIndex]) = (list[pivotIndex], list[i]);
                    pivotIndex = i;
                }
            }
            
            QuickSort(list, start, pivotIndex - 1);
            QuickSort(list, pivotIndex + 1, end);
        }
    }
}
