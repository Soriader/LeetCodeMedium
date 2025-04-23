namespace LeetCodeMedium;

public class LongestPalindromicSubstringTask
{
    public static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }
    
        string result = s[0].ToString();
    
        for (int i = 0; i < s.Length; i++) 
        {
            string odd = ExpandAroundCenter(s, i, i);
            
            if (odd.Length > result.Length)
            {
                result = odd;
            }
        
            string even = ExpandAroundCenter(s, i, i + 1);
            
            if (even.Length > result.Length)
            {
                result = even;
            }
        }
    
        return result;
    }

    private static string ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right]) 
        {
            left--;
            right++;
        }
        
        return s.Substring(left + 1, right - left - 1);
    }
}
//https://leetcode.com/problems/longest-palindromic-substring/description/