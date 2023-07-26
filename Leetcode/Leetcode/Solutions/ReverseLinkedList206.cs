using Leetcode.Solutions.Models;

namespace Leetcode.Solutions;

public class ReverseLinkedList206
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}