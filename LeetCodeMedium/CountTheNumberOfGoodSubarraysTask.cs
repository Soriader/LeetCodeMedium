namespace LeetCodeMedium;

public class CountTheNumberOfGoodSubarraysTask
{
    public static long CountGood(int[] nums, int k)
    {
        if (k == 1)
        {
            return CountSubarraysWithAtLeastOnePair(nums);
        }
        
        int left = 0;
        long result = 0;
        long totalPairs = 0;
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        for (int right = 0; right < nums.Length; right++) 
        {
            if (!frequency.ContainsKey(nums[right]))
            {
                frequency[nums[right]] = 0;
            }
            
            totalPairs += frequency[nums[right]];
            frequency[nums[right]]++;
            
            while (totalPairs >= k) {
                result += nums.Length - right;
                
                totalPairs -= frequency[nums[left]] - 1;
                frequency[nums[left]]--;
                left++;
            }
        }
        
        return result;
    }
    
    private static long CountSubarraysWithAtLeastOnePair(int[] nums) 
    {
        long totalSubarrays = (long)nums.Length * (nums.Length + 1) / 2;
        long subarraysWithoutPairs = 0;
        
        Dictionary<int, int> lastPos = new Dictionary<int, int>();
        int start = 0;
        
        for (int end = 0; end < nums.Length; end++) {
            if (lastPos.ContainsKey(nums[end])) {
                start = Math.Max(start, lastPos[nums[end]] + 1);
            }
            subarraysWithoutPairs += end - start + 1;
            lastPos[nums[end]] = end;
        }
        
        return totalSubarrays - subarraysWithoutPairs;
    }
}
//https://leetcode.com/problems/count-the-number-of-good-subarrays/?envType=daily-question&envId=2025-04-16