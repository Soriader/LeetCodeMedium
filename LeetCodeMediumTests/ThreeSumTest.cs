namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class ThreeSumTest
{
    [Test]
    public void ReverseInteger()
    {
        var result = ThreeSumTask.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
        var expected = new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } };

        var sortedResult = result.OrderBy(t => string.Join(",", t)).ToList();
        var sortedExpected = expected.OrderBy(t => string.Join(",", t)).ToList();

        Assert.AreEqual(sortedExpected, sortedResult);
    }
}