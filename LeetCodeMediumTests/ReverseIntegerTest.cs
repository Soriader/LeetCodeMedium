namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class ReverseIntegerTest
{
    [Test]
    public void ReverseInteger()
    {
        Assert.AreEqual(321, ReverseIntegerTask.Reverse(123));
        Assert.AreEqual(-321, ReverseIntegerTask.Reverse(-123));
        Assert.AreEqual(21, ReverseIntegerTask.Reverse(120));
    }
}