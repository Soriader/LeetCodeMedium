namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class RabbitsInForestTest
{
    [Test]
    public void RabbitsInForest()
    {
        Assert.AreEqual(5, RabbitsInForestTask.NumRabbits(new int[] { 1,1,2 }));    
        Assert.AreEqual(11, RabbitsInForestTask.NumRabbits(new int[] { 10,10,10}));    

    }
}