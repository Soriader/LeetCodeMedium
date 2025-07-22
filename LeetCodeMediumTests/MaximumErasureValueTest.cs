namespace LeetCodeMediumTests;

public class MaximumErasureValueTest
{
    [Test]
    public void MaximumErasureValue()
    {
        Assert.AreEqual(17, MaximumErasureValueTask.MaximumUniqueSubarray(new int[]{4,2,4,5,6}));
        Assert.AreEqual(8, MaximumErasureValueTask.MaximumUniqueSubarray(new int[]{5,2,1,2,5,2,1,2,5}));
    }
}