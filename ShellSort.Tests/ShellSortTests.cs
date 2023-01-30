

namespace ShellSort.Tests;

[TestClass]
public class ShellSortTests
{
    [TestMethod]
    [DataRow(new int[] { 73, 57, 49, 99, 133, 20, 1 }, new int[] { 1, 20, 49, 57, 73, 99, 133 })]
    public void Sorts_Array_ReturnsSortedArray(int[] x, int[] expected)
    {
        var shellSort = new ShellSort();
        var actual = shellSort.Sort(x);

        Assert.IsNotNull(actual);
        CollectionAssert.AreEqual(actual, expected);
    }
}
