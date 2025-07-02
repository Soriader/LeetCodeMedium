namespace LeetCodeMedium;

public class HouseRobberTask
{
    public static int Rob(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }        
        if (nums.Length == 1)
        {
            return nums[0];
        }        
        if (nums.Length == 2)
        {
            return nums.Max();
        }
        
        int[] maxMoney = new int[nums.Length];
        maxMoney[0] = nums[0];
        maxMoney[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            maxMoney[i] = Math.Max(maxMoney[i - 1], maxMoney[i - 2] + nums[i]);
        }

        return maxMoney[nums.Length - 1];
    }
}
//https://leetcode.com/problems/house-robber/