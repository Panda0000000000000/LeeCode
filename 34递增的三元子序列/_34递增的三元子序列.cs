/***************************************************
	日期：2022/08/28  14:16
	作者：夏
	描述：给你一个整数数组 nums ，判断这个数组中是否存在长度为 3 的递增子序列。
    如果存在这样的三元组下标 (i, j, k) 且满足 i < j < k ，使得 nums[i] < nums[j] < nums[k] ，返回 true ；否则，返回 false 。
        //这里得考点  可能就是贪心算法  TMD 这道题花了老子一个半小时的时间

    目前已知的两种解法
        //贪心算法
        //双向遍历
****************************************************/
using System;

namespace _34递增的三元子序列
{
    class _34递增的三元子序列
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IncreasingTriplet_1(new int[] { 0, 4, 2, 1, 0, -1, -3 });
        }

        //贪心算法
        public bool IncreasingTriplet(int[] nums)
        {
            int a = nums[0], b = int.MaxValue;
            int i = 1, len = nums.Length;
            while (i < len)
            {
                int num = nums[i];
                if (num > b)
                {
                    return true;
                }
                else
                {
                    if (num > a)
                    {
                        b = num;
                    }
                    else if (num < a)
                    {
                        a = num;
                    }
                }
                i++;
            }

            return false;
        }

        //双向遍历
        public static bool IncreasingTriplet_1(int[] nums)
        {
            int n = nums.Length;
            int[] leftMin = new int[n];
            int[] rightMax = new int[n];

            leftMin[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                leftMin[i] = Math.Min(leftMin[i - 1], nums[i]);
            }

            rightMax[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], nums[i]);
            }
            for (int i = 1; i < n - 1; i++)
            {
                if (leftMin[i - 1] < nums[i] && nums[i] < rightMax[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        //官方给的贪心算法
        public static bool IncreasingTriplet_2(int[] nums)
        {
            int n = nums.Length;
            if (n < 3)
            {
                return false;
            }
            int first = nums[0], second = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                int num = nums[i];
                if (num > second)
                {
                    return true;
                }
                else if (num > first)
                {
                    second = num;
                }
                else if (num <= first)
                {
                    first = num;
                }
            }
            return false;
        }
    }
}
