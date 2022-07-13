using System;

namespace 寻找两个有序数组的中位数
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            FindMedianSortedArrays_1(new int[]{},new int[] { 1 });
            Console.ReadKey();
        }

        //暴力求解 合并两个有序数组 然后找出中位数 时间复杂度 O(m+n)  空间复杂度O(m+n)
        public static double FindMedianSortedArrays_1(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            if (m == 0)
            {
                if (n % 2 == 0)
                {
                    return (nums2[n / 2] + nums2[n / 2 - 1]) / 2.0;
                }
                else
                {
                    return nums2[n / 2];
                }
            }

            if (n == 0)
            {
                if (m % 2 == 0)
                {
                    return (nums1[m / 2] + nums1[m / 2 - 1]) / 2.0;
                }
                else
                {
                    return nums1[m / 2];
                }
            }

            int[] nums;

            nums = new int[m + n];

            int count = 0;
            int i = 0, j = 0;
            while (count != (m + n))
            {
                if (i == m)
                {
                    while (j != n)
                    {
                        nums[count++] = nums2[j++];
                    }
                    break;
                }

                if (j == n)
                {
                    while (i != m)
                    {
                        nums[count++] = nums1[i++];
                    }
                    break;
                }

                if (nums1[i] < nums2[j])
                {
                    nums[count++] = nums1[i++];
                }
                else
                {
                    nums[count++] = nums2[j++];
                }
            }

            int len_Nums = nums.Length;
            if (nums.Length % 2 == 0)
            {
                return (nums[len_Nums / 2] + nums[(len_Nums / 2 )-1]) / 2.0;
            }
            else
            {
                return nums[nums.Length/2];
            }
        }

        //二分查找法
        public static double FindMedianSortedArrays_2(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;

            if (m>n)
            {
                int[] numsTemp = nums2;
                nums2 = nums1;
                nums1 = numsTemp;
            }
            
        }
    }
}