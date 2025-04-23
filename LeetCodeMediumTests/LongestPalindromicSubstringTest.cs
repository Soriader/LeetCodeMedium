namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class LongestPalindromicSubstringTest
{
    [Test]
    public void LongestPalindromicSubstring()
    {
        Assert.AreEqual("bb", LongestPalindromicSubstringTask.LongestPalindrome("cbbd"));
    }
}