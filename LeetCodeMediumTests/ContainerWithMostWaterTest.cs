namespace LeetCodeMediumTests;

using LeetCodeMedium;


public class ContainerWithMostWaterTest
{
    [Test]
    public void ContainerWithMostWater()
    {
        Assert.AreEqual(49, ContainerWithMostWaterTask.MaxArea(new int[]{1,8,6,2,5,4,8,3,7}));
        Assert.AreEqual(1, ContainerWithMostWaterTask.MaxArea(new int[]{1,1}));
    }
}