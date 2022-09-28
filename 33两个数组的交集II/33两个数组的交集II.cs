/***************************************************
	日期：2022/08/28  13:47
	作者：夏
	描述：找出两个数组出现次数相同的元素
****************************************************/

using System;
using System.Collections.Generic;

namespace _33两个数组的交集II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Intersect_1(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
        }

        //哈希表       还没调试好 时间没来得及 先不管这个了
        public static int[] Intersect_1(int[] nums1, int[] nums2)
        {
            int[] min = nums1.Length >= nums2.Length ? nums2 : nums1;
            int[] max = nums1.Length >= nums2.Length ? nums1 : nums2;

            int len_Min = min.Length;
            int len_Max = max.Length;

            int resault_Len = 0;

            Dictionary<int, int> cache_DicIntCount = new Dictionary<int, int>(len_Min);
            for (int i = 0; i < len_Min; i++)
            {
                if (!cache_DicIntCount.ContainsKey(min[i]))
                {
                    cache_DicIntCount.Add(min[i], 1);
                }
                else
                {
                    cache_DicIntCount[min[i]]++;
                }
            }

            for (int i = 0; i < len_Max; i++)
            {
                if (cache_DicIntCount.ContainsKey(max[i]))
                {
                    if (cache_DicIntCount[max[i]] >= 1)
                    {
                        min[resault_Len] = max[i];
                        cache_DicIntCount[max[i]]--;
                        resault_Len++;
                    }
                }
            }
            int[] resault = new int[resault_Len];
            Array.Copy(nums1, resault, resault_Len);
            return resault;
        }

        //排序加双指针
        public int[] Intersect_2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0;
            int j = 0;
            int r = 0;

            while (i<nums1.Length&&j<nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    nums1[r++] = nums1[i];
                    i++;
                    j++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            int[] resault = new int[r];
            Array.Copy(nums1, resault, r);
            return resault;
        }
    }
}