namespace _50相交链表
{
    internal class _50相交链表
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA==null||headB==null)
            {
                return null;
            }

            ListNode nodeA = headA;
            ListNode nodeB = headB;
            while (nodeA!=nodeB)
            {
                nodeA = nodeA == null ? headB : nodeA.next;
                nodeB = nodeB == null ? headA : nodeB.next;
            }

            return nodeA; 
        }
    }
}