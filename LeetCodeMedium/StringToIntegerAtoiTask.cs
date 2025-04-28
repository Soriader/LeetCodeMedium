namespace LeetCodeMedium;

public class StringToIntegerAtoiTask
{
    public static int MyAtoi(string s)
    {    
        int index = 0;
        int sign = 1;
        int result = 0;
    
        while (index < s.Length && s[index] == ' ')
        {
            index++;
        }
    
        if (index < s.Length && (s[index] == '+' || s[index] == '-'))
        {
            sign = s[index] == '-' ? -1 : 1;
            index++;
        }
    
        while (index < s.Length && char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';
        
            if (result > (int.MaxValue - digit) / 10)
            {
                return sign == -1 ? int.MinValue : int.MaxValue;
            }
        
            result = result * 10 + digit;
            index++;
        }
    
        return result * sign;
    }
}
//https://leetcode.com/problems/string-to-integer-atoi/description/