namespace LeetCodeMedium;

public class FindTheMaximumLengthOfValidSubsequenceITask
{
    public static int MaximumLength(int[] nums)
    {   
        
        int[,] dp = new int[2, 2];

        foreach (int x in nums)
        {
            int r = x % 2;
            for (int y = 0; y < 2; y++)
            {
                dp[r, y] = dp[y, r] + 1;
            }
        }

        int result = 0;
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result = Math.Max(result, dp[i, j]);
            }
        }

        return result;
    }
}
//https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-i/?envType=daily-question&envId=2025-07-16