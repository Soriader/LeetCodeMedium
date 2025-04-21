namespace LeetCodeMedium;

public class CountTheHiddenSequencesTask
{
    public static int NumberOfArrays(int[] differences, int lower, int upper) 
    {
        long minHidden0 = lower;
        long maxHidden0 = upper;
        long currentSum = 0;
    
        foreach (var diff in differences)
        {
            currentSum += diff;
        
            minHidden0 = Math.Max(minHidden0, lower - currentSum);
            maxHidden0 = Math.Min(maxHidden0, upper - currentSum);
        
            if (minHidden0 > maxHidden0)
            {
                return 0;
            }        
        }
    
        return (int)(maxHidden0 - minHidden0 + 1);
    }
}
//https://leetcode.com/problems/count-the-hidden-sequences/?envType=daily-question&envId=2025-04-21