public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null){
            return false;
        }
        
        if (head.next == null) {
            return true;
        }
        
        if (head.next.next == null) {
            return head.val == head.next.val;
        }
        
        var slow = head;
        var fast = head;
        
        while (fast !=null && fast.next !=null){
            slow = slow.next;
            fast = fast.next.next;
        }
        
        slow = Reverse(slow);
        fast = head;
            
        while (slow != null) {
            if (slow.val != fast.val) {
                return false;
            }
            
            slow = slow.next;
            fast = fast.next;
        }
        
        return true;
    }
    
    private ListNode Reverse(ListNode head) {
        ListNode prev = null;
        while (head != null) {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        
        return prev;
    }
}

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