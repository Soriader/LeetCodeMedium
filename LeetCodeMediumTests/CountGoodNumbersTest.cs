namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class CountGoodNumbersTest
{
    [Test]
    public void CountGoodNumbers()
    {
        Assert.AreEqual(5, CountGoodNumbersTask.CountGoodNumbers(1));    
        Assert.AreEqual(400, CountGoodNumbersTask.CountGoodNumbers(4));  
        Assert.AreEqual(564908303, CountGoodNumbersTask.CountGoodNumbers(50)); 
        Assert.AreEqual(100, CountGoodNumbersTask.CountGoodNumbers(3)); 
        Assert.AreEqual(1, CountGoodNumbersTask.CountGoodNumbers(0));
    }
}