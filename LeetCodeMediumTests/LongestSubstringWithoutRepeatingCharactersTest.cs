namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class LongestSubstringWithoutRepeatingCharactersTest
{
    [Test]
    public void LongestSubstringWithoutRepeatingCharacters()
    {
        Assert.AreEqual(3, LongestSubstringWithoutRepeatingCharactersTask.LengthOfLongestSubstring("abcabcbb"));    
        Assert.AreEqual(1, LongestSubstringWithoutRepeatingCharactersTask.LengthOfLongestSubstring("bbbbb"));    
        Assert.AreEqual(3, LongestSubstringWithoutRepeatingCharactersTask.LengthOfLongestSubstring("pwwkew"));    

    }
}