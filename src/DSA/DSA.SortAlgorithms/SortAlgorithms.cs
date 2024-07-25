using System.ComponentModel.DataAnnotations;

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

    public static void QuickSort(List<int> list, int low = 0, int? high = null)
    {
        high ??= list.Count - 1;

        if (low < high)
        {
            static int Partition(List<int> subList, int low, int high)
            {
                int pivot = subList[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (subList[j] <= pivot)
                    {
                        i++;
                        (subList[i], subList[j]) = (subList[j], subList[i]);
                    }
                }

                (subList[i + 1], subList[high]) = (subList[high], subList[i + 1]);
                return i + 1;
            }

            int pivotIndex = Partition(list, low, high.Value);
            QuickSort(list, low, pivotIndex - 1);
            QuickSort(list, pivotIndex + 1, high.Value);
        }
    }

    public static void CountingSort(List<int> list)
    {
        int maxList = list.Max();
        List<int> count = Enumerable.Repeat(0, maxList + 1).ToList();
        foreach (int item in list)
        {
            count[item]++;
        }

        int i = 0;
        for (int j = 0; j < count.Count; j++)
        {
            while (count[j]-- > 0)
            {
                list[i++] = j;
            }
        }
    }

    public static void RadixSort(List<int> list)
    {
        List<List<int>> radixList = Enumerable.Range(0, 10).Select(_ => new List<int>()).ToList();
        int maxValue = list.Max();
        int exp = 1;

        while (maxValue / exp > 0)
        {
            foreach (int val in list)
            {
                int radixIndex = (val / exp) % 10;
                radixList[radixIndex].Add(val);
            }

            int i = 0;
            foreach (List<int> bucket in radixList)
            {
                foreach (int val in bucket)
                {
                    list[i++] = val;
                }
                bucket.Clear();
            }

            exp *= 10;
        }
    }
}
