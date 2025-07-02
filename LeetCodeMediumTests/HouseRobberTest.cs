using LeetCodeMedium;

namespace LeetCodeMediumTests;

public class HouseRobberTest
{
    [Test]
    public void HouseRobber()
    {
        Assert.AreEqual(4, HouseRobberTask.Rob(new int[]{1,2,3,1}));
        Assert.AreEqual(12, HouseRobberTask.Rob(new int[]{2,7,9,3,1}));
    }
}