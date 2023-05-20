namespace ConsoleApp1;

/// <summary>
/// Get distinct elements of array
/// </summary>
public static class Program_1_4
{
    /// <summary>
    /// Check is element exists in array (Linq.Any() analog)
    /// </summary>
    /// <param name="array">Result array</param>
    /// <param name="value">Value</param>
    /// <returns>True - if element exists, False - if element doesn't exist</returns>
    private static bool IsElementExist(IEnumerable<int> array, int value)
    {
        foreach (var item in array)
        {
            if (item == value) return true;
        }

        return false;
    }
    
    /// <summary>
    /// Get distinct elements in array
    /// </summary>
    /// <param name="sourceArray">Source array</param>
    /// <returns>Distinct elements of source array</returns>
    public static int[] GetDistinctElements(IEnumerable<int> sourceArray)
    {
        var result = new List<int>();
        foreach (var item in sourceArray)
        {
            if (!IsElementExist(result, item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }
}

