/***************************************************
	日期：2022/09/07  14:56
	作者：夏
	描述：给你单链表的头节点 head ，请你反转链表，并返回反转后的链表。

            第一反应是用栈来写

    
****************************************************/

using System.Runtime.InteropServices;

namespace _51反转链表
{
    internal class _51反转链表
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ListNode a = new ListNode(1);
            ListNode b = a;
            a.next = new ListNode(2);
            a = a.next;
            a.next = new ListNode(3);
            a = a.next;
            a.next = new ListNode(4);
            a = a.next;
            a.next = new ListNode(5);
            ReverseList_2(b);
        }
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

        //栈
        public ListNode ReverseList(ListNode head)
        {
            if (head==null)
            {
                return null;
            }
            Stack<ListNode> cache = new Stack<ListNode>();
            ListNode node = head;
            while (node!=null)
            {
                cache.Push(node);
                node = node.next;
            }

            ListNode resault = new ListNode(cache.Pop().val);
            ListNode resaultCache = resault;
            while (cache.Count>0)
            {
                resault.next = new ListNode(cache.Pop().val);
                resault = resault.next;
            }

            return resaultCache;
        }

        //迭代
        public static ListNode ReverseList_1(ListNode head)
        {
            ListNode pref = null;
            ListNode curr = head;
            while (curr!=null)
            {
                ListNode next = curr.next;
                curr.next = pref;
                pref = curr;
                curr = next;
            }

            return pref;
        }

        //递归
        public static ListNode ReverseList_2(ListNode head)
        {
            if (head==null|| head.next==null)
            {
                return head;
            }

            ListNode node = ReverseList_2(head.next);
            head.next.next = head;
            head.next = null;
            return node;
        }
    }
}
