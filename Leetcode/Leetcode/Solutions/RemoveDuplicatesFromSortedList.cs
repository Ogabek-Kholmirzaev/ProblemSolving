using Leetcode.Solutions.Models;

namespace Leetcode.Solutions;

public class RemoveDuplicatesFromSortedList
{
    public static ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return head;

        var current = head;

        while (current.next != null)
        {
            if (current.val == current.next.val)
                current.next = current.next.next;
            else
                current = current.next;
        }

        return head;
    }
}