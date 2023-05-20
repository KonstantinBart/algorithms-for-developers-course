using ConsoleApp1;
using NUnit.Framework;

namespace AlgorithmsTestsProject_1;

public class UnitTests_1_3
{
    [Test]
    [TestCase(new[] { 3, 16, 94, 8, 55 }, 2, new[] { 94, 55 })]
    [TestCase(new[] { 3, 16, 94, 8, 55 }, 5, new[] { 94, 55,16,8,3 })]
    [TestCase(new[] { 3, 16, 94, 8, 55 }, 0, new int [0])]
    public void TestAnyMaxElements(int [] sourceArray, int maxElementsCount, int [] expectedResultArray)
    {
        var result = Program_1_3.GetMaxElements(sourceArray, maxElementsCount);
        Assert.AreEqual(result, expectedResultArray);
    }
}