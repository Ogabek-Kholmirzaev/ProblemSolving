using Leetcode.Solutions.Models;

namespace Leetcode.Solutions;

public class RemoveLinkedListElements203
{
    public static ListNode RemoveElements(ListNode head, int val)
    {
        while (head.next != null && head.next.val == val)
            head = head.next;

        if (head == null)
            return head;

        var current = head;

        while (current.next != null)
        {
            if(current.next.val == val)
                current.next = current.next.next;
            else
                current = current.next;
        }

        return head;
    }
}