/***************************************************
	作者：夏
	描述：二叉搜索树具有以下性质：
 ****************************************************/

using System.Text;

namespace _59二叉树的最近公共祖先
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode ans;
            bool dfs(TreeNode root, TreeNode p, TreeNode q, out TreeNode ans)
            {
                ans = null;
                if (root == null)
                {
                    return false;
                }

                bool l = dfs(root.left, p, q, out ans);
                bool r = dfs(root.right, p, q, out ans);

        }
    }
}
}