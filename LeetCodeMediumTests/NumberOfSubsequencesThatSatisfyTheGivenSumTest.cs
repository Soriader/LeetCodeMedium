using LeetCodeMedium;

namespace LeetCodeMediumTests;

public class NumberOfSubsequencesThatSatisfyTheGivenSumTest
{
    [Test]
    public void NumberOfSubsequencesThatSatisfyTheGivenSum()
    {
        Assert.AreEqual(4, NumberOfSubsequencesThatSatisfyTheGivenSumTask.NumSubseq(new int[]{3,5,6,7}, 9));
    }

}