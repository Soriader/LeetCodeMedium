namespace LeetCodeMediumTests;

public class MaximumMatchingOfPlayersWithTrainersTest
{
    [Test]
    public void MaximumMatchingOfPlayersWithTrainers()
    {
        Assert.AreEqual(2, MaximumMatchingOfPlayersWithTrainersTask.MatchPlayersAndTrainers(new int[]{4,7,9}, new int[]{ 8, 2, 5, 8 }));
        Assert.AreEqual(1, MaximumMatchingOfPlayersWithTrainersTask.MatchPlayersAndTrainers(new int[]{1,1,1}, new int[]{10}));
    }
}