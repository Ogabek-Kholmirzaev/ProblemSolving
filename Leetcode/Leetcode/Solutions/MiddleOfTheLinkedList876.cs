using Leetcode.Solutions.Models;

namespace Leetcode.Solutions;

public class MiddleOfTheLinkedList876
{
    public static ListNode MiddleNode(ListNode head)
    {
        var cnt = 0;
        ListNode slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            cnt++;
        }

        return slow;
    }
}