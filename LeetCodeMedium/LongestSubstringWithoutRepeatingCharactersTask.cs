namespace LeetCodeMedium;

public class LongestSubstringWithoutRepeatingCharactersTask
{
    public static int LengthOfLongestSubstring(string s) 
    {
        var boxForLetters  = new List<char>();
        int result = 0;
    
        for (int i = 0; i < s.Length; i++)
        {
            if (boxForLetters .Contains(s[i]))
            {
                int index = boxForLetters .IndexOf(s[i]);
                boxForLetters .RemoveRange(0, index + 1);
            }
        
            boxForLetters .Add(s[i]);
        
            if (boxForLetters.Count > result)
            {
                result = boxForLetters .Count;
            }
        }
    
        return result;
    }
}
//https://leetcode.com/problems/longest-substring-without-repeating-characters/