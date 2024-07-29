using System.Collections.Generic;

namespace DSA.Tests.Unit.SortAlogorithms.Models;

/// <summary>
/// Sort algorithms test caces.
/// </summary>
public class SortAlgorithmsTestCase
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
    /// ExpectedOutput.
    /// </summary>
    public List<int> ExpectedOutput { get; set; }
}
