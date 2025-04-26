using System.Text;

namespace LeetCodeMedium;

public class IntegerToRomanTask
{
    public static string IntToRoman(int num)
    {
        var romanNumerals = new Dictionary<int, string>
        {
            {1000, "M"}, 
            {900, "CM"}, 
            {500, "D"}, 
            {400, "CD"},
            {100, "C"}, 
            {90, "XC"}, 
            {50, "L"}, 
            {40, "XL"},
            {10, "X"}, 
            {9, "IX"}, 
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        var result = new StringBuilder();
        
        foreach (var pair in romanNumerals)
        {
            while (num >= pair.Key)
            {
                result.Append(pair.Value);
                num -= pair.Key;
            }
        }
        return result.ToString();
    }
}
//https://leetcode.com/problems/integer-to-roman/description/