namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class LetterCombinationsOfAPhoneNumberTest
{
    [Test]
    public void EmptyInput()
    {
        var result = LetterCombinationsOfAPhoneNumberTask.LetterCombinations("");
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void SingleDigit2()
    {
        var result = LetterCombinationsOfAPhoneNumberTask.LetterCombinations("2");
        var expected = new List<string> { "a", "b", "c" };
        CollectionAssert.AreEquivalent(expected, result);
    }

    [Test]
    public void SingleDigit9()
    {
        var result = LetterCombinationsOfAPhoneNumberTask.LetterCombinations("9");
        var expected = new List<string> { "w", "x", "y", "z" };
        CollectionAssert.AreEquivalent(expected, result);
    }

    [Test]
    public void TwoDigits23()
    {
        var result = LetterCombinationsOfAPhoneNumberTask.LetterCombinations("23");
        var expected = new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
        CollectionAssert.AreEquivalent(expected, result);
    }

    [Test]
    public void TwoDigits_79()
    {
        var result = LetterCombinationsOfAPhoneNumberTask.LetterCombinations("79");
        var expected = new List<string> 
        { 
            "pw", "px", "py", "pz",
            "qw", "qx", "qy", "qz",
            "rw", "rx", "ry", "rz",
            "sw", "sx", "sy", "sz"
        };
        CollectionAssert.AreEquivalent(expected, result);
    }


}