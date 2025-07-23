namespace LeetCodeMediumTests;

public class MaximumScoreFromRemovingSubstringsTest
{
    [Test]
    public void MaximumScoreFromRemovingSubstrings()
    {
        Assert.AreEqual(19, MaximumScoreFromRemovingSubstringsTask.MaximumGain("cdbcbbaaabab", 4, 5));
    }
}