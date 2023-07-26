using Leetcode.Solutions.Models;

namespace Leetcode.Solutions;

public class MergeTwoSortedLists21
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list1;

        if (list2 == null)
            return list1;

        if (list1.val <= list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}