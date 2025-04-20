namespace LeetCodeMedium;

public class RabbitsInForestTask
{
    public static int NumRabbits(int[] answers)
    {
        if (answers.Length == 0)
        {
            return 0;
        }

        var answerCount = new Dictionary<int, int>();
    
        foreach (var answer in answers)
        {
            if (answerCount.ContainsKey(answer))
            {
                answerCount[answer]++;
            }
            else
            {
                answerCount[answer] = 1;
            }
        }
    
        int totalRabbits = 0;

        foreach (var pair in answerCount)
        {
            int x = pair.Key;      
            int k = pair.Value;    
        
            int groups = (k + x) / (x + 1); 
            totalRabbits += groups * (x + 1);
        }
    
        return totalRabbits;
    }
}
//https://leetcode.com/problems/rabbits-in-forest/description/?envType=daily-question&envId=2025-04-20