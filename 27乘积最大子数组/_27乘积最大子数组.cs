/***************************************************
	日期：2022/08/28  11:39
	作者：夏
	描述：给你一个整数数组 nums ，请你找出数组中乘积最大的非空连续子数组（该子数组中至少包含一个数字），并返回该子数组所对应的乘积。
    测试用例的答案是一个 32-位 整数。
    子数组 是数组的连续子序列。

    因为这里只要求给出乘积最大子数组的积，所以动态规划不需要开辟额外的空间记录状态    

****************************************************/

using System;

namespace _27乘积最大子数组
{
    class _27乘积最大子数组
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //进阶版 数学版  实际上是动态规划的本质版，理解难度极大
        public int MaxProduct(int[] nums)
        {
            int ans = nums[0];
            int preMax = nums[0];
            int preMin = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int max = preMax * nums[i], min = preMin * nums[i];
                preMax = Math.Max(nums[i], Math.Max(max,min));
                preMin = Math.Min(nums[i], Math.Min(max, min));

                ans = Math.Max(ans, preMax);
            }

            return ans;
        }

        //动态规划简单版
        public int MaxProduct_1(int[] nums)
        {
            int ans = nums[0];
            int len = nums.Length;
            int[] dpMax = new int[len];
            int[] dpMin = new int[len];

            dpMax[0] = nums[0];
            dpMin[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int max = dpMax[i - 1] * nums[i], min = dpMin[i -1] * nums[i];

                dpMax[i] = Math.Max(nums[i],Math.Max(max,min));
                dpMin[i] = Math.Min(nums[i], Math.Min(max, min));

                ans = Math.Max(ans,dpMax[i]);
            }

            return ans;
        }
    }
}
