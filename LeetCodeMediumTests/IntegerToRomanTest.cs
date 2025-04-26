namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class IntegerToRomanTest
{
    [Test]
    public void IntegerToRoman()
    {
        Assert.AreEqual("MMMDCCXLIX", IntegerToRomanTask.IntToRoman(3749));
    }
}