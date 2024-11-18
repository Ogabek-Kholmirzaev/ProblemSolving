namespace Leetcode.TheLeetcodeBeginnersGuide;

public class MiddleOfTheLinkedList {
    public ListNode MiddleNode(ListNode head) {
        ListNode middle = head, end = head;

        while (end != null && end.next != null) {
            end = end.next.next;
            middle = middle.next;
        }

        return middle;
    }
}

public class ListNode { 
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}