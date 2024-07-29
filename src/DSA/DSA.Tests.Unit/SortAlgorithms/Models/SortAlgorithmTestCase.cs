using System.Collections.Generic;

namespace DSA.Tests.Unit.SortAlogorithms.Models;

/// <summary>
/// Sort algorithm test cace.
/// </summary>
public class SortAlgorithmTestCase
{
    /// <summary>
    /// Description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Input.
    /// </summary>
    public List<int> Input { get; set; }

    /// <summary>
    /// Expected Output.
    /// </summary>
    public List<int> ExpectedOutput { get; set; }
}
