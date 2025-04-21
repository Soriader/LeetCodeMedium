namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class CountTheHiddenSequencesTest
{
    [Test]
    public void CountTheHiddenSequences()
    {
        Assert.AreEqual(2, CountTheHiddenSequencesTask.NumberOfArrays(new int[] { 1,-3,4 }, 1, 6));    
        Assert.AreEqual(4, CountTheHiddenSequencesTask.NumberOfArrays(new int[] { 3,-4,5,1,-2 }, -4, 5));    
        Assert.AreEqual(0, CountTheHiddenSequencesTask.NumberOfArrays(new int[] { 4,-7,2 }, 3, 6));    
    }
}