namespace LeetCodeMedium;

public class ContainerWithMostWaterTask
{
    public static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int currentHeight = Math.Min(height[left], height[right]);
            int currentArea = width * currentHeight;

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
//https://leetcode.com/problems/container-with-most-water/submissions/1618364281/