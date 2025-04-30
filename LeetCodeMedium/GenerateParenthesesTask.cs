namespace LeetCodeMedium;

public class GenerateParenthesesTask
{
    public static IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        GenerateBracket(n, n, "", result);
        return result;
    }

    private static void GenerateBracket(int openRemaining, int closeRemaining, string current, List<string> result)
    {
        if (openRemaining == 0 && closeRemaining == 0)
        {
            result.Add(current);
            return;
        }

        if (openRemaining > 0)
        {
            GenerateBracket(openRemaining - 1, closeRemaining, current + "(", result);
        }

        if (closeRemaining > openRemaining)
        {
            GenerateBracket(openRemaining, closeRemaining - 1, current + ")", result);
        }
    }
}
//https://leetcode.com/problems/generate-parentheses/description/