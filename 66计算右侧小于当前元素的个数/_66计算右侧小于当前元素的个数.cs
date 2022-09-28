using System.Runtime.CompilerServices;

namespace _66计算右侧小于当前元素的个数
{
    internal class _66计算右侧小于当前元素的个数
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class TreeNode{
            public TreeNode left;
            public TreeNode right;
            public int value;
            public int count;
            public TreeNode(int value)
            {
                this.value = value;
            }
        }

        //二叉搜索树 没过，但是不想用这种解法了
        public IList<int> CountSmaller(int[] nums)
        {
            IList<int> resault = new List<int>();
            TreeNode root = null;
            for (int i = nums.Length-2; i >=0; i--)
            {
                root = CreatTreeNode(root, new TreeNode(nums[i]), i, ref resault);
            }
             
            TreeNode CreatTreeNode(TreeNode root, TreeNode node,int index,ref IList<int> resault)
            {
                if (root==null)
                {
                    return node;
                }

                if (node.value >= root.value)
                {
                    root.count++;
                    root.left = CreatTreeNode(root.left, node, index,ref resault);
                }
                else
                {
                    resault[index] += root.count;
                    root.right = CreatTreeNode(root.right, node, index, ref resault);
                }

                return root;
            }

            return resault;
        }
    }
}