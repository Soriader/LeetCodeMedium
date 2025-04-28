namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class Find_FirstAndLastPositionOfElementInSortedArrayTest
{
    [Test]
    public void Find_FirstAndLastPositionOfElementInSortedArray1()
    {
        var nums = new int[] { 1, 2, 3, 4, 5 };
        var target = 6;
        var expected = new int[] { -1, -1 };
        
        var result = new Find_FirstAndLastPositionOfElementInSortedArrayTask().SearchRange(nums, target);
        
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void Find_FirstAndLastPositionOfElementInSortedArray2()
    {
        var nums = new int[] { 1 };
        var target = 1;
        var expected = new int[] { 0, 0 };
        
        var result = new Find_FirstAndLastPositionOfElementInSortedArrayTask().SearchRange(nums, target);
        
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void Find_FirstAndLastPositionOfElementInSortedArray3()
    {
        var nums = new int[] { 5, 5, 5, 5, 5 };
        var target = 5;
        var expected = new int[] { 0, 4 };
        
        var result = new Find_FirstAndLastPositionOfElementInSortedArrayTask().SearchRange(nums, target);
        
        Assert.AreEqual(expected, result);
    }
}