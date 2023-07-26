using Leetcode.Solutions.Models;

namespace Leetcode.Solutions;

public class MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode();
        var current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
        }

        current.next = list1 ?? list2;

        return head.next;
    }
}