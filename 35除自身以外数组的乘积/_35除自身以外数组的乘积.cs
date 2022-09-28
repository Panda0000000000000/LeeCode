/***************************************************
	日期：2022/08/28  16:27
	作者：夏
	描述：给你一个整数数组 nums，返回 数组 answer ，其中 answer[i] 等于 nums 中除 nums[i] 之外其余各元素的乘积 。 不使用除法，时间复杂度O（n）
        
            //左右乘积列表 时间复杂度O（n）  空间复杂度O(n) 这种方法很巧妙的还是
            //左乘积列表  时间复杂度O(n) 空间复杂度O(1) 结果列表不计算在空间复杂度内  上一种方法的进阶取巧版，不是很容易被理解
****************************************************/

using System;

namespace _35除自身以外数组的乘积
{
    class _35除自身以外数组的乘积
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //左右乘积列表
        public static int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            int[] left = new int[len];
            left[0] = 1;
            for (int i = 1; i < len; i++)
            {
                left[i] = left[i-1] * nums[i-1];
            }

            int[] right = new int[len];
            right[len - 1] = 1;
            for (int i = len-2; i >=0; i--)
            {
                right[i] = right[i + 1] * nums[i+1];
            }

            int[] resault = new int[len];
            for (int i = 0; i < len; i++)
            {
                resault[i] = left[i] * right[i];
            }

            return resault;
        }

        //左乘积列表
        public static int[] ProductExceptSelf_1(int[] nums)
        {
            int len = nums.Length;
            int[] leftNums = new int[len];
            leftNums[0] = 1;
            for (int i = 1; i < len; i++)
            {
                leftNums[i] = leftNums[i - 1] * nums[i - 1];
            }

            int R = 1;
            for (int i = len-1; i>=0; i--)
            {
                leftNums[i] = leftNums[i] * R;
                R *= nums[i];
            }

            return leftNums;
        }
    }
}
