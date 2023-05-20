namespace ConsoleApp1;

/// <summary>
/// Find max element in array
/// </summary>
public static class Program_1_2
{
    public static void Main() {}

    /// <summary>
    /// Show max element using standard sorting
    /// </summary>
    /// <param name="arr">Source array</param>
    public static void ShowMaxElementWithStandardSorting(List<int> arr)
    {
        arr.Sort();
        Console.WriteLine("Sort result = " + arr.ElementAt(arr.Count - 1));
    }

    /// <summary>
    /// Show max element using manual sorting
    /// </summary>
    /// <param name="arr"></param>
    public static void ShowMaxElementWithManualSorting(int[] arr)
    {
        var maxValue = int.MinValue;
        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxValue) maxValue = arr[i];
        }
        Console.WriteLine("Sort result = " + maxValue);
    }
}

