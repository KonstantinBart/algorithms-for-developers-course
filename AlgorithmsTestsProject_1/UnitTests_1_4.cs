using ConsoleApp1;
using NUnit.Framework;

namespace AlgorithmsTestsProject_1;

public class UnitTests_1_4
{
    [Test]
    public void TestDistinctElementsInArray()
    {
        var sourceArray = new [] { 3, 8, 8, 4, 2, 2 };
        var result = Program_1_4.GetDistinctElements(sourceArray);
        Assert.AreEqual(result, new[] { 3, 8, 4, 2 });
    }
}