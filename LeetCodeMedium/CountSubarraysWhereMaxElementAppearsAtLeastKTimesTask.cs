namespace LeetCodeMedium;

public class CountSubarraysWhereMaxElementAppearsAtLeastKTimesTask
{
    public long CountSubarrays(int[] nums, int k)
    {
        int maxNum = nums.Max();
        long result = 0;
        int count = 0; 
        int left = 0;  

        for (int right = 0; right < nums.Length; right++) 
        {
            if (nums[right] == maxNum) 
            {
                count++;
            }

            while (count >= k)
            {
                if (nums[left] == maxNum) 
                {
                    count--;
                }
                left++;
            }

            result += left;
        }

        return result;
    }
}
//https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times/description/?envType=daily-question&envId=2025-04-29