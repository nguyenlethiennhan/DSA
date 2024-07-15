using System.Runtime.CompilerServices;

namespace DSA.SortAlgorithms;

public static class ListExtensions
{
    public static void Print(this List<int> list)
    {
        Console.WriteLine("-----List-----");
        foreach (var item in list) { Console.Write(item.ToString() + " "); }
        Console.WriteLine();
    }
}
