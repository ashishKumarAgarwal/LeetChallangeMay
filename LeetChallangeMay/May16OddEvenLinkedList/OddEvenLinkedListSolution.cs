namespace LeetChallengeMay.May16OddEvenLinkedList
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class OddEvenLinkedListSolution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode oddPointer = head;
            ListNode evenPointer = head.next;
            ListNode connectingNode = head.next;

            while (evenPointer != null && evenPointer.next != null)
            {
                oddPointer.next = evenPointer.next;
                oddPointer = oddPointer.next;
                evenPointer.next = oddPointer.next;
                evenPointer = evenPointer.next;
            }

            oddPointer.next = connectingNode;
            return head;
        }
    }
}