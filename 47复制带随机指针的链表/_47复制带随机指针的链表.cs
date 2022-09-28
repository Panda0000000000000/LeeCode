using System.Xml.Linq;
using System.Collections.Generic;

namespace _47复制带随机指针的链表
{
    internal class _47复制带随机指针的链表
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        Dictionary<Node,Node> cacheNode = new Dictionary<Node,Node>();
        //回溯+哈希表
        public Node CopyRandomList_1(Node head)
        {
            if (head == null)
            {
                return null;
            }
            if (!cacheNode.ContainsKey(head))
            {
                Node newHead = new Node(head.val);
                cacheNode.Add(head, newHead);
                newHead.next = CopyRandomList_1(head.next);
                newHead.random= CopyRandomList_1(head.random);
            }

            return cacheNode[head];
        }

        //迭代+节点拆分  理解不了
        public Node CopyRandomList_2(Node head)
        {
            if (head==null)
            {
                return null;
            }

            for (Node node = head;node != null; node = node.next.next)
            {
                Node nodeNew = new Node(node.val);
            }
        }
    }
}