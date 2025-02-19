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
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var dummy   = new ListNode(0);
        var current = dummy;
        var carry   = 0;

        while (l1 != null || l2 != null)
        {
            var x   = l1?.val ?? 0;
            var y   = l2?.val ?? 0;
            var sum = carry + x + y;

            carry        = sum / 10;
            current.next = new ListNode(sum % 10);
            current      = current.next;
            l1           = l1?.next;
            l2           = l2?.next;
        }

        if (carry > 0)
            current.next = new ListNode(carry);

        return dummy.next;
    }
}