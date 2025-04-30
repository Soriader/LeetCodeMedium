namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class GenerateParenthesesTest
{
    [Test]
    public void GenerateParentheses()
    {
        Assert.AreEqual(new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" },
            GenerateParenthesesTask.GenerateParenthesis(3));

        Assert.AreEqual(new List<string>() { "()"},
            GenerateParenthesesTask.GenerateParenthesis(1));
    }
}