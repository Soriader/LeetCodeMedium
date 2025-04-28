namespace LeetCodeMedium;

public class ListNodeToTask 
{
    public int val;
    public ListNode next;
    
    public ListNodeToTask(int val = 0, ListNode next = null) 
    {
        this.val = val;
        this.next = next;
    }
}

public class RemoveNthNodeFromEndOfListTask
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode fast = dummy;
        ListNode slow = dummy;

        for (int i = 0; i <= n; i++)
        {
            fast = fast.next;
        }

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}
//https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/