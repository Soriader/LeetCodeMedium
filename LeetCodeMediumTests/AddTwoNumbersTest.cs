namespace LeetCodeMediumTests;

using LeetCodeMedium;

public class AddTwoNumbersTest
{
        [Test]
    public void AddTwoNumbers()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // 342
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // 465
        var expected1 = new ListNode(7, new ListNode(0, new ListNode(8))); // 807 (342 + 465)
        Assert.AreEqual(ListNodeToString(expected1), ListNodeToString(new AddTwoNumbersTask().AddTwoNumbers(l1, l2)));

        var l3 = new ListNode(9, new ListNode(9)); // 99
        var l4 = new ListNode(1); // 1
        var expected2 = new ListNode(0, new ListNode(0, new ListNode(1))); // 100 (99 + 1)
        Assert.AreEqual(ListNodeToString(expected2), ListNodeToString(new AddTwoNumbersTask().AddTwoNumbers(l3, l4)));

        var l5 = new ListNode(1, new ListNode(8)); // 81
        var l6 = new ListNode(0); // 0
        var expected3 = new ListNode(1, new ListNode(8)); // 81 (81 + 0)
        Assert.AreEqual(ListNodeToString(expected3), ListNodeToString(new AddTwoNumbersTask().AddTwoNumbers(l5, l6)));

        var l7 = new ListNode(0);
        var l8 = new ListNode(0);
        var expected4 = new ListNode(0); // 0 (0 + 0)
        Assert.AreEqual(ListNodeToString(expected4), ListNodeToString(new AddTwoNumbersTask().AddTwoNumbers(l7, l8)));

        var l9 = new ListNode(9, new ListNode(9, new ListNode(9))); // 999
        var l10 = new ListNode(1); // 1
        var expected5 = new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1)))); // 1000 (999 + 1)
        Assert.AreEqual(ListNodeToString(expected5), ListNodeToString(new AddTwoNumbersTask().AddTwoNumbers(l9, l10)));
    }

    private static string ListNodeToString(ListNode head)
    {
        var result = new System.Text.StringBuilder();
        
        while (head != null)
        {
            result.Append(head.val);
            if (head.next != null)
            {
                result.Append(" -> ");
            }
            head = head.next;
        }
        return result.ToString();
    }
}