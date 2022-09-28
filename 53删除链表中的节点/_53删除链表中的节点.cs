namespace _53删除链表中的节点
{
    internal class _53删除链表中的节点
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

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}