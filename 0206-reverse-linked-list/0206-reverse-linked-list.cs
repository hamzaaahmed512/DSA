/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }
        ListNode prev = null;
        ListNode current = head;
        while(current != null)
        {
            ListNode post = current.next;
            current.next=prev;
            prev=current;
            current=post;
        }
        return prev;
    }
}