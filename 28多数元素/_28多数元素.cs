/***************************************************
	日期：2022/08/27  22:16
	作者：夏
	描述：找出数组中数量最多的元素，要求时间复杂度为O（n）,空间复杂度为O（1）
                这道题TM的官方给了五个算法

            1.Boyer-Moore 投票算法 摩尔投票  我觉得摩尔投票就是目前的最优解法
****************************************************/

using System;

namespace _28多数元素
{
    class _28多数元素
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MajorityElement(int[] nums)
        {
            int ans = nums[0];
            int count = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == ans)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count==0)
                {
                    ans = nums[i];
                    count = 1;
                }
            }

            return ans;
        }
    }
}
