namespace DSA.ConsoleApplication.Extensions;

public static class ListExtensions
{
    public static void Print(this List<int> list)
    {
        Console.WriteLine("-----List-----");
        foreach (int item in list) { Console.Write(item.ToString() + " "); }
        Console.WriteLine();
    }
}
