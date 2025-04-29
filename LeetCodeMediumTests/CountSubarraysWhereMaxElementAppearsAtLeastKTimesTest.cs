namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest
{
    [Test]
    public void CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest1()
    {
        var solution = new CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask();
        int[] nums = { 1, 3, 2, 3, 3 };
        int k = 2;
        long expected = 6;
        
        long result = solution.CountSubarrays(nums, k);
        
        Assert.AreEqual(expected, result);
    }

        [Test]
    public void CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest2()
    {
        var solution = new CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask();
        int[] nums = { 1, 4, 2, 1 };
        int k = 3;
        long expected = 0;
        
        long result = solution.CountSubarrays(nums, k);
        
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest3()
    {
        var solution = new CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask();
        int[] nums = { 5, 5, 5, 5 };
        int k = 2;
        long expected = 6; // (4+3+2+1) - 4 = 6 (dla k=2)
        
        long result = solution.CountSubarrays(nums, k);
        
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest4()
    {
        var solution = new CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask();
        int[] nums = { 2 };
        int k = 1;
        long expected = 1;
        
        long result = solution.CountSubarrays(nums, k);
        
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest5()
    {
        var solution = new CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask();
        int[] nums = { 2 };
        int k = 2;
        long expected = 0;
        
        long result = solution.CountSubarrays(nums, k);
        
        Assert.AreEqual(expected, result);
    }
    

    [Test]
    public void CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest6()
    {
        var solution = new CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask();
        int[] nums = { 1, 2, 1, 2 };
        int k = 3;
        long expected = 0;
        
        long result = solution.CountSubarrays(nums, k);
        
        Assert.AreEqual(expected, result);
    }

}