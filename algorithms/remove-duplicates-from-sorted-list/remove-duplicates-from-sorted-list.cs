/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var curNode = head;
        if (curNode == null || curNode.next == null)
            return head;
        var nextNode = curNode.next;
        if (curNode.val == nextNode.val) {
            curNode.next = nextNode.next;
            DeleteDuplicates(curNode);
        }
        else {
            DeleteDuplicates(nextNode);
        }
        
        return head;
        
    }
}