/***************************************************
	日期：2022/08/28  12:30
	作者：夏
	描述：给你一个整数数组 nums 。如果任一值在数组中出现 至少两次 ，返回 true ；如果数组中每个元素互不相同，返回 false 。
            不知道这道题的考点是什么 字典吗？
****************************************************/

using System;
using System.Collections.Generic;

namespace _30存在重复元素
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //在字典里面存储
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> cache_Count = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!cache_Count.ContainsKey(nums[i]))
                {
                    cache_Count.Add(nums[i], 1);
                }
                else
                {
                    cache_Count[nums[i]]++;
                }
            }

            foreach (var item in cache_Count)
            {
                if (item.Value>1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
