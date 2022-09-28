/***************************************************
	日期：2022/09/08  20:03
	作者：夏
	描述：二叉搜索树具有以下性质：
 
    结点的左子树只包含小于当前结点的数。
    结点的右子树只包含大于当前结点的数。
    所有左子树和右子树自身必须也是二叉搜索树。

            也就是右边全是比他大的 左边全是比他小的

 ****************************************************/

namespace _58二叉搜索树中第K小的元素
{
    internal class _58二叉搜索树中第K小的元素
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

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

        public int KthSmallest(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root!=null || stack.Count>0)
            {
                while (root!=null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                --k;
                if (k==0)
                {
                    break;
                }
                root = root.right;
            }

            return root.val;
        }
    }
}