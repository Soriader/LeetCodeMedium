namespace LeetCodeMedium;

public class MaximumErasureValueTask
{
    public static int MaximumUniqueSubarray(int[] nums)
    {
        var maxSum = 0;
        var currentSum = 0;
        var uniqueNumbers = new HashSet<int>();
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            while (uniqueNumbers.Contains(nums[right]))
            {
                uniqueNumbers.Remove(nums[left]);
                currentSum -= nums[left];
                left++;
            }

            uniqueNumbers.Add(nums[right]);
            currentSum += nums[right];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        return maxSum;
    }
}
//https://leetcode.com/problems/maximum-erasure-value/description/?envType=daily-question&envId=2025-07-22