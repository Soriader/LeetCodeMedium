namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class DivideTwoIntegersTest
{
    [Test]
    public void CountGoodNumbers()
    {
        Assert.AreEqual(3, DivideTwoIntegersTask.Divide(10, 3));
        Assert.AreEqual(-2, DivideTwoIntegersTask.Divide(7, -3));
    }
}