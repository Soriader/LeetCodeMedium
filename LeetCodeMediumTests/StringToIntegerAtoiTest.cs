namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class StringToIntegerAtoiTest
{
    [Test]
    public void StringToIntegerAtoi()
    {
        Assert.AreEqual(42, StringToIntegerAtoiTask.MyAtoi("42"));
        Assert.AreEqual(-42, StringToIntegerAtoiTask.MyAtoi("-042"));
        Assert.AreEqual(1337, StringToIntegerAtoiTask.MyAtoi("1337c0d3"));
        Assert.AreEqual(0, StringToIntegerAtoiTask.MyAtoi("words and 987"));
    }
}