namespace LeetCodeMedium;

public class LetterCombinationsOfAPhoneNumberTask
{
    private static Dictionary<char, string> phoneKeyMap = new Dictionary<char, string>()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    public static IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return result;
        }

        GenerateCombinations(digits, 0, "", result);
        return result;
    }

    private static void GenerateCombinations(string digits, int index, string current, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(current);
            return;
        }

        char digit = digits[index];
        string letters = phoneKeyMap[digit];

        for (int i = 0; i < letters.Length; i++)
        {
            GenerateCombinations(digits, index + 1, current + letters[i], result);
        }
    }
}
//https://leetcode.com/problems/letter-combinations-of-a-phone-number/submissions/1609875896/