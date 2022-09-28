/***************************************************
	日期：2022/08/28  13:23
	作者：夏
	描述：给你一个整数数组 nums ，设计算法来打乱一个没有重复元素的数组。打乱后，数组的所有排列应该是 等可能 的。

        我不明白这道题的考点是什么

        好像是洗牌算法？ 考点是每个位置有的选择都一样的就可以 都是n-i种选择
****************************************************/
using System;

namespace _32打乱数组
{
    class _32打乱数组
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Solution
        {
            int[] nums;
            int[] nums_Shuffle;

            public Solution(int[] nums)
            {
                this.nums = nums;
                nums_Shuffle = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums_Shuffle[i] = nums[i];
                }
            }

            public int[] Reset()
            {
                return nums;
            }
            public int[] Shuffle()
            {
                Random random = new Random();

                int len = nums.Length;
                for (int i = 0; i < nums.Length; i++)
                {
                    int j =i+random.Next(len - i);
                    int temp = nums_Shuffle[i];
                    nums_Shuffle[i] = nums_Shuffle[j];
                    nums_Shuffle[j] = temp;
                }
                return nums_Shuffle;
            }
        }
    }
}
