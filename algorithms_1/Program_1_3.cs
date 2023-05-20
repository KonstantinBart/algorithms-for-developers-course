namespace ConsoleApp1;

/// <summary>
/// Find any max elements in array
/// </summary>
public static class Program_1_3
{
    /// <summary>
    /// Get max element in array less than value
    /// </summary>
    /// <param name="arr">Source array</param>
    /// <param name="value">Max value</param>
    private static int GetMaxElement(IReadOnlyList<int> arr, int value)
    {
        var maxValue = int.MinValue;
        foreach (var element in arr)
        {
            if (element < value)
                maxValue = Math.Max(element, maxValue);
        }

        return maxValue;
    }

    /// <summary>
    /// Get any last maximum elements 
    /// </summary>
    /// <param name="sourceArray">Source array</param>
    /// <param name="maxElementsCount">Max elements count</param>
    /// <returns>MaxElementsCount last maximum elements</returns>
    public static int[] GetMaxElements(int[] sourceArray, int maxElementsCount)
    {
        var result = new int[maxElementsCount];
        var previousMax = int.MaxValue;
        for (var i = 0; i < maxElementsCount; i++)
        {
            var maxElement = GetMaxElement(sourceArray, previousMax);
            previousMax = maxElement;
            result[i] = maxElement;
        }
        
        return result;
    }
}

