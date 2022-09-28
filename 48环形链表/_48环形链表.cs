/***************************************************
	日期：2022/09/05  16:07
	作者：夏
    	描述：给你一个链表的头节点 head ，判断链表中是否有环。如果链表中有某个节点，可以通过连续跟踪 next 指针再次到达，则链表中存在环。 
         为了表示给定链表中的环，评测系统内部使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。
        注意：pos 不作为参数进行传递 。仅仅是为了标识链表的实际情况。如果链表中存在环 ，则返回 true 。 否则，返回 false 。

            考点应该就是  Floyd判圈算法  经常在算法面试中出现

            1.哈希表  不推荐
            2.快慢指针

****************************************************/

using System.Text;
using System.Xml;

namespace _48环形链表
{
    internal class _48环形链表
    {
        static void Main(string[] args)     
        {
            Console.WriteLine("Hello, World!");
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        //哈希+遍历
        public bool HasCycle(ListNode head)
        {
            List<ListNode> cacheNode = new List<ListNode>();
            ListNode node = head;
            while (node!=null && !cacheNode.Contains(node))
            {
                cacheNode.Add(node);
                node = node.next;
            }

            return node != null;
        }



        //快慢指针
        public bool HasCycle_1(ListNode head)
        {
            if (head==null)
            {
                return false;
            }

            ListNode node_Slow = head;
            ListNode node_Fast = head.next;

            while (node_Slow != node_Fast)
            {
                if(node_Fast==null || node_Fast.next==null)
                {
                    return false;
                }

                node_Slow = node_Slow.next;
                node_Fast = node_Fast.next.next;
            }

            return true;
        }
    }
}