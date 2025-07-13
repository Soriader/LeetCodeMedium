namespace LeetCodeMedium;

public class MaximumMatchingOfPlayersWithTrainersTask
{
    public static int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);
        
        int result = 0;
        int playerIndex = 0;
        int trainerIndex = 0;

        while (playerIndex < players.Length && trainerIndex < trainers.Length)
        {
            if (players[playerIndex] <= trainers[trainerIndex])
            {
                result++;
                playerIndex++;
                trainerIndex++;
            }
            else
            {
                trainerIndex++;
            }
        }

        return result;
    }
}
//https://leetcode.com/problems/maximum-matching-of-players-with-trainers/?envType=daily-question&envId=2025-07-13