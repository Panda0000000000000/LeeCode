using System;
using System.Collections.Generic;

namespace 二叉树的中序遍历
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


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //递归
        public static IList<int> InorderTraversal_1(TreeNode root)
        {

            IList<int> resault = new List<int>();
            inorder(root, ref resault);
            return resault;
            static void inorder(TreeNode root, ref IList<int> res)
            {
                if (root == null)
                {
                    return;
                }

                inorder(root.left, ref res);
                res.Add(root.val);
                inorder(root.right, ref res);
            }
        }

        public static IList<int> InorderTraversal_1_S(TreeNode root)
        {
            IList<int> resault = new List<int>();

            inorder(root, ref resault);
            return resault;

            void inorder(TreeNode root,ref IList<int> resault)
            {
                if (root==null)
                {
                    return;
                }

                inorder(root.left, ref resault);
                resault.Add(root.val);
                inorder(root.right, ref resault);
            }
        }
    }
}                                                                                                                                                                 