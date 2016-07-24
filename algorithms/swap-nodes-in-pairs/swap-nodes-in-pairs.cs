/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode prepreNode = null;
        var preNode = head;
        var curNode = preNode == null ? null : preNode.next;
        var nextNode = curNode == null ? null : curNode.next;
        var result = curNode == null ? head : curNode;
        while (nextNode != null)
        {
            if (prepreNode != null)
                prepreNode.next = curNode;
            curNode.next = preNode;
            preNode.next = nextNode;
            prepreNode = preNode;
            preNode = nextNode;
            curNode = preNode.next;
            nextNode = curNode == null ? null : curNode.next;
        }
        if (preNode != null && curNode != null)
        {
            if (prepreNode != null)
                prepreNode.next = curNode;
            curNode.next = preNode;
            preNode.next = null;

        }
        return result;
    }
}