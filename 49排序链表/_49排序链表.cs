/***************************************************
	日期：2022/09/06  16:42
	作者：夏
	描述：  要使用归并排序、

            //自顶向下的空间复杂度是O(log n)
            //自顶向上的空间复杂度是O（1）

****************************************************/

using System.Diagnostics;

namespace _49排序链表
{
    internal class _49排序链表
    {
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ListNode head = new ListNode(4);
            ListNode node = head;
            head.next = new ListNode(2);
            head = head.next;
            head.next = new ListNode(1);
            head = head.next;
            head.next = new ListNode(3);

            SortList(node);
        }

        //自顶向下
        public static ListNode SortList(ListNode head)
        {
            return sortList(head, null);
            static ListNode sortList(ListNode head, ListNode tail)
            {
                if (head==null)
                {
                    return head;
                }
                if (head.next == tail)
                {
                    head.next = null;
                    return head;
                }

                ListNode slow = head, fast = head;
                while (fast!=tail)
                {
                    slow = slow.next;
                    fast = fast.next;
                    if (fast!=tail)
                    {
                        fast = fast.next;
                    }
                }

                ListNode mid = slow;
                ListNode temp1 = sortList(head, mid);
                ListNode temp2 = sortList(mid, tail);
                ListNode sorted = merge(temp1, temp2);
                return sorted;
            }
             
            static ListNode merge(ListNode head1, ListNode head2)
            {
                ListNode cache = new ListNode(0);
                ListNode temp = cache, temp1 = head1, temp2 = head2;

                while (temp1 != null && temp2 != null)
                {
                    if (temp1.val <= temp2.val)
                    {
                        temp.next = temp1;
                        temp1 = temp1.next;
                    }
                    else
                    {
                        temp.next = temp2;
                        temp2 = temp2.next;
                    }
                    temp = temp.next;
                }

                if (temp1 == null)
                {
                    temp.next = temp2;
                }
                else
                {
                    temp.next = temp1;
                }

                return cache.next;
            }
        }
    }
}
