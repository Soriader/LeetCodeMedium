using System.Text;

namespace LeetCodeMedium;

public class MaximumScoreFromRemovingSubstringsTask
{
    public static int MaximumGain(string s, int x, int y)
    {
        bool prioritizeAB = x >= y;
        
        string firstTarget = prioritizeAB ? "ab" : "ba";
        string secondTarget = prioritizeAB ? "ba" : "ab";
        int firstPoints = prioritizeAB ? x : y;
        int secondPoints = prioritizeAB ? y : x;

        int totalPoints = 0;
        var stack1 = new Stack<char>();

        foreach (char c in s)
        {
            if (stack1.Count > 0 && stack1.Peek() == firstTarget[0] && c == firstTarget[1])
            {
                stack1.Pop();
                totalPoints += firstPoints;
            }
            else
            {
                stack1.Push(c);
            }
        }

        var stack2 = new Stack<char>();
        
        foreach (char c in stack1.Reverse())
        {
            if (stack2.Count > 0 && stack2.Peek() == secondTarget[0] && c == secondTarget[1])
            {
                stack2.Pop();
                totalPoints += secondPoints;
            }
            else
            {
                stack2.Push(c);
            }
        }

        return totalPoints;
    }
}
//https://leetcode.com/problems/maximum-score-from-removing-substrings/description/?envType=daily-question&envId=2025-07-23