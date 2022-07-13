using System;

namespace LeeCode
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

    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1 = l1.next;
            l1.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2 = l2.next;
            l2.next = new ListNode(4);

            ListNode resault = AddTwoNumbers_(l1, l2);
            Console.ReadKey();
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            int sum = 0;
            int more = 0;
            ListNode pre = dummy;
            while(l1!=null||l2!=null||more>0)
            {
                sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + more;
                more = sum / 10;
                sum %= 10;
                ListNode node = new ListNode(sum);
                pre.next = node;
                pre = node;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            return dummy.next;
        }
























        public static ListNode AddTwoNumbers_(ListNode l1, ListNode l2)
        {
            ListNode listNode_Resault = new ListNode(0);
            ListNode node_Cache = listNode_Resault;

            int more = 0;
            while (l1 != null || l2 != null || more != 0)
            {
                int num_1 = l1!=null?l1.val : 0;
                int num_2 = l2 != null ? l2.val : 0;

                int sum = num_1 + num_2 + more;
                sum = sum % 10;
                more = sum / 10;

                ListNode sum_Node = new ListNode(sum);

                node_Cache.next = sum_Node;
                node_Cache = sum_Node;
                
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            return listNode_Resault.next;
        }
    }
}