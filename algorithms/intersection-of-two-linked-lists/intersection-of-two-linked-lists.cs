/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null)
            return null;
        int countA = 0, countB = 0;
        ListNode ptrA = headA, ptrB = headB;
        while (ptrA != null) {
            countA++;
            ptrA = ptrA.next;
        }
        while (ptrB != null) {
            countB++;
            ptrB = ptrB.next;
        }
        ptrA = headA; 
        ptrB = headB;
        for (int i = 0; i < Math.Abs(countA - countB); i++) {
            if (countA > countB)
                ptrA = ptrA.next;
            else
                ptrB = ptrB.next;
        }
        while (ptrA != null) {
            if (ptrA == ptrB)
                return ptrA;
            ptrA = ptrA.next;
            ptrB = ptrB.next;
        }
        return null;
    }
}