using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ConsoleApp1;
using NUnit.Framework;

namespace AlgorithmsTestsProject_1;

public class UnitTests_1_2
{
    private List<int> _sourceArrayFirst; 
    private int[] _sourceArraySecond;
    private Stopwatch _stopwatch;
    
    [SetUp]
    public void Setup()
    {
        var random = new Random(123);
        _sourceArrayFirst = Enumerable.Range(0, 10000000).Select(_ => random.Next()).ToList();
        _sourceArraySecond = new int[_sourceArrayFirst.Count];
        _sourceArrayFirst.CopyTo(_sourceArraySecond, 0);
        _stopwatch = Stopwatch.StartNew();
    }

    [TearDown]
    public void Teardown()
    {
        Console.WriteLine($"Sort: {_stopwatch.Elapsed}");
        _stopwatch.Stop();
    }

    [Test]
    public void TestStandardSort()
    {
        Program_1_2.ShowMaxElementWithStandardSorting(_sourceArrayFirst);
    }
    
    [Test]
    public void TestManualSort()
    {
        Program_1_2.ShowMaxElementWithManualSorting(_sourceArraySecond);
    }
}