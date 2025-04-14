namespace LeetCodeMedium;
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class AddTwoNumbersTask
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode result = new ListNode(0);
        ListNode current = result;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;

            int total = val1 + val2 + carry;
            carry = total / 10;
            current.next = new ListNode(total % 10);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        return result.next; 
    }
}

//https://leetcode.com/problems/add-two-numbers/description/