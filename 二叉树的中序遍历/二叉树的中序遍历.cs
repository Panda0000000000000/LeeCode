using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;

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

    class 二叉树的中序遍历
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //递归
        public static IList<int> InorderTraversal_1_S(TreeNode root)
        {
            IList<int> resault = new List<int>();

            inorder(root, ref resault);
            return resault;

            void inorder(TreeNode root, ref IList<int> resault)
            {
                if (root == null)
                {
                    return;
                }

                inorder(root.left, ref resault);
                resault.Add(root.val);
                inorder(root.right, ref resault);
            }
        }

        public static IList<int> InorderTraversal_1_S_(TreeNode root)
        {
            IList<int> resault = new List<int>();

            inorde(root, ref resault);

            void inorde(TreeNode root,ref IList<int> resault)
            {
                if (root==null)
                {
                    return;
                }

                inorde(root.left, ref resault);
                resault.Add(root.val);
                inorde(root.right, ref resault);
            }

            return resault;
        }

        //迭代
        public static IList<int> InorderTraversal_2(TreeNode root)
        {
            IList<int> resault = new List<int>();
            //迭代
            Stack<TreeNode> stk = new Stack<TreeNode>();
            while (root!=null || stk.Count>0)
            {
                while (root!=null)
                {
                    stk.Push(root);
                    root = root.left;
                }

                root = stk.Pop();
                resault.Add(root.val);
                root = root.right;
            }

            return resault;
        }

        //Morris 
        public static IList<int> InorderTraversal_3(TreeNode root)
        {
            IList<int> ans = new List<int>();
            while (root!=null)
            {
                if (root.left == null)
                {
                    ans.Add(root.val);
                    root = root.right;
                }
                else
                {
                    TreeNode pre = root.left;
                    while (pre.right!=null && pre.right!=root)
                    {
                        pre = pre.right;
                    }

                    if (pre.right == null)
                    {
                        pre.right = root;
                        root = root.left;
                    }
                    else
                    {
                        pre.right = null;
                        ans.Add(root.val);
                        root = root.right;
                    }
                }
            }

            return ans;
        }
    }
}