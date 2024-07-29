using System.Collections.Generic;

namespace DSA.Tests.Unit.SearchAlgorithms.Models;

/// <summary>
/// Search algorithm test case.
/// </summary>
public class SearchAlgorithmTestCase
{
    /// <summary>
    /// Description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Input.
    /// </summary>
    public Input Input { get; set; }

    /// <summary>
    /// Expected Output.
    /// </summary>
    public int? ExpectedOutput { get; set; }
}

public class Input
{
    /// <summary>
    /// List input
    /// </summary>
    public List<int> Array { get; set; }

    /// <summary>
    /// Target
    /// </summary>
    public int Target { get; set; }
}