/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = null, curNode = new ListNode(0);
        ListNode curNode1 = l1;
        ListNode curNode2 = l2;
        while (curNode1 != null || curNode2 != null) {
            if (curNode1 == null || curNode2 == null) {
                if (curNode1 == null) {
                    curNode.next = curNode2;
                    curNode2 = null;
                }
                else {
                    curNode.next = curNode1;
                    curNode1 = null;
                }
            }
            else {
                if (curNode1.val < curNode2.val) {
                    curNode.next = new ListNode(curNode1.val);
                    curNode1 = curNode1.next;
                }
                else {
                    curNode.next = new ListNode(curNode2.val);
                    curNode2 = curNode2.next;
                }
            }
            curNode = curNode.next;
            if (head == null)
                head = curNode;
        }
        return head;
    }
}