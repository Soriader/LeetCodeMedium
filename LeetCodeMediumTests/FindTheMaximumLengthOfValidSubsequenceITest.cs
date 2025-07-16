namespace LeetCodeMediumTests;

public class FindTheMaximumLengthOfValidSubsequenceITest
{
    [Test]
    public void FindTheMaximumLengthOfValidSubsequenceI()
    {
        Assert.AreEqual(4, FindTheMaximumLengthOfValidSubsequenceITask.MaximumLength(new int[]{1,2,3,4}));
        Assert.AreEqual(6, FindTheMaximumLengthOfValidSubsequenceITask.MaximumLength(new int[]{1,2,1,1,2,1,2}));
        Assert.AreEqual(2, FindTheMaximumLengthOfValidSubsequenceITask.MaximumLength(new int[]{1,3}));
        Assert.AreEqual(4, FindTheMaximumLengthOfValidSubsequenceITask.MaximumLength(new int[]{2,13,26,70,76}));
    }
}