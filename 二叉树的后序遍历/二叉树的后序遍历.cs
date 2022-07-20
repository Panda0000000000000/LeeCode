using System;
using System.Collections.Generic;

namespace 二叉树的后序遍历
{
    class 二叉树的后序遍历
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //递归
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> resault = new List<int>();

            preorder(root, ref resault);

            return resault;

            void preorder(TreeNode root, ref IList<int> resault)
            {
                if (root == null)
                {
                    return;
                }

                preorder(root.left, ref resault);
                preorder(root.right, ref resault);
                resault.Add(root.val);
            }
        }


    }
}
