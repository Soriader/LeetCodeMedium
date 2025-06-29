namespace LeetCodeMedium;

public class NumberOfSubsequencesThatSatisfyTheGivenSumTask
{
    public static int NumSubseq(int[] nums, int target) 
    {
        
        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;
        int result = 0;
        int mod = 1000000007;
    
        int[] pow = new int[nums.Length + 1];
        
        pow[0] = 1;
        
        for (int i = 1; i <= nums.Length; i++)
        {
            pow[i] = (pow[i - 1] * 2) % mod;
        }
    
        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                result = (result + pow[right - left]) % mod;
                left++;
            }
            else
            {
                right--;
            }
        }
    
        return result;
        
    }
}
//https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition/description/?envType=daily-question&envId=2025-06-29