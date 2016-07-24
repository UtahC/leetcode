/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
            return head;
        var preNode = head;
        var curNode = head.next;
        var nextNode = head.next.next;
        while (curNode != null) {
            curNode.next = preNode;
            preNode = curNode;
            curNode = nextNode;
            if (nextNode != null)
                nextNode = nextNode.next;
        }
        head.next = null;
        return preNode;
    }
}