namespace LeetCodeMediumTests;

using LeetCodeMedium;


public class RemovingMinimumNumberOfMagicBeansTest
{
    [Test]
    public void RemovingMinimumNumberOfMagicBeans()
    {
        Assert.AreEqual(4, RemovingMinimumNumberOfMagicBeansTask.MinimumRemoval(new int[] { 4, 1, 6, 5 }));
        Assert.AreEqual(7, RemovingMinimumNumberOfMagicBeansTask.MinimumRemoval(new int[] { 2,10,3,2}));
    }
}