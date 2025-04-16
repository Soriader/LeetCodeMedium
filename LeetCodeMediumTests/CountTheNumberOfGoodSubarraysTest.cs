namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class CountTheNumberOfGoodSubarraysTest
{
    [Test]
    public void CountGood_ExampleCase_k2_Returns4()
    {
        int[] nums = { 3, 1, 4, 3, 2, 2, 4 };
        int k = 2;
        long result = CountTheNumberOfGoodSubarraysTask.CountGood(nums, k);
        Assert.AreEqual(4, result);
    }
    
    
}