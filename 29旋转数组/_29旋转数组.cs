/***************************************************
	日期：2022/08/27  22:00
	作者：夏
	描述：旋转数组 将数组向后移动k位，超出长度的从数组开始按需补位；

            1.数组翻转：解决问题的算法是一种取巧的规律算法，先将整个数组翻转，然后再从k位为分割线，将0>k-1,k>len-1 分别翻转，得到的值就是整个数组旋转k位的结果
            2.环状替换 这题真正的考点因该是这个解法，但是我还不会；

****************************************************/
using System;

namespace _29旋转数组
{
    class _29旋转数组
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
        }

        //数组翻转
        public static void Rotate(int[] nums, int k)
        {
            //这里不需要什么  只需要取余数就可以，因为数组的旋转是循环，所以会有很多重复的操作，这一步就是去重
            k = k % nums.Length;

            int len = nums.Length;
            RotatNums(nums, 0, len-1);
            RotatNums(nums, 0, k-1);
            RotatNums(nums, k,len-1);

            void RotatNums(int[] nums,int l,int r)
            {
                while (l<r)
                {
                    nums[l] += nums[r];
                    nums[r] = nums[l] - nums[r];
                    nums[l] = nums[l] - nums[r];
                    l++;
                    r--;
                }
            }
        }

        //环状翻转
        public static void Rotate_1(int[] nums, int k)
        {
            k = k % nums.Length;
            int len = nums.Length;
            int count = 0;
            int index = 0;
            while (count<=len)
            {
                int pos = (index + k) % nums.Length;
                nums[pos] += nums[index];
                nums[index] = nums[pos] - nums[index];
                nums[pos] = nums[pos] - nums[index];
                index = pos;
                count++;
            }
        }
    }
}