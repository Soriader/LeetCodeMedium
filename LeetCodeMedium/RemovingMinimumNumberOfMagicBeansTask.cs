namespace LeetCodeMedium;

public class RemovingMinimumNumberOfMagicBeansTask
{
    public static long MinimumRemoval(int[] beans)
    {
        Array.Sort(beans);
        long total = beans.Sum(b => (long)b);
        long minRemoval = long.MaxValue;
    
        for (int i = 0; i < beans.Length; i++) 
        {
            if (i > 0 && beans[i] == beans[i-1])
            {
                continue;
            }
            
            long x = beans[i];
            long count = beans.Length - i;
            long removed = total - x * count;
            
            if (removed < minRemoval) 
            {
                minRemoval = removed;
            }
        }
    
        return minRemoval;
    }
    
}

//https://leetcode.com/problems/removing-minimum-number-of-magic-beans/description/

//Good result but to slow 
/*public static long MinimumRemoval(int[] beans)
{
    int iterator = 0;
    long result = 0;
    var boxForBeans = new List<long>();

    while (iterator < beans.Length)
    {
        foreach (var bean in beans)
        {
            if (bean < beans[iterator])
            {
                boxForBeans.Add(bean);
            }
            else if (bean > beans[iterator])
            {
                    
                boxForBeans.Add(bean - beans[iterator]);

            }
        }

        if (boxForBeans.Sum() < result)
        {
            result = boxForBeans.Sum();
        }
        else if (result == 0)
        {
            result = boxForBeans.Sum();
        }

        iterator++;
        boxForBeans.Clear();
    }
        
    return result;
}*/