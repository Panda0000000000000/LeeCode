using System;

namespace 寻找两个有序数组的中位数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FindMedianSortedArrays_1(new int[] { }, new int[] { 1 });
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
                return (nums[len_Nums / 2] + nums[(len_Nums / 2) - 1]) / 2.0;
            }
            else
            {
                return nums[nums.Length / 2];
            }
        }

        //循环遍历查找法
        public static double FindMedianSortedArrays_2(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int len = m + n;
            int left = -1, right = -1;
            int aStart = 0, bStart = 0;
            for (int i = 0; i < len/2; i++)
            {
                left = right;
                if (aStart < m && (bStart >= n || nums1[aStart] < nums2[bStart]))
                {
                    right = nums1[aStart++];
                }
                else
                {
                    right = nums2[bStart++];
                }
            }

            if ((len & 1) == 0)
            {
                return (left + right) / 2.0;
            }
            else
            {
                return right;
            }
        }

        //循环遍历查找法 自己实现
        public static double FindMedianSortedArrays_3(int[] nums1, int[] nums2)
        {
            int a = nums1.Length, b = nums2.Length;
            int aStart, bStart = 0;

            int left, right = -1;
            int len = a + b;
            for (int i = 0; i < len/2; i++)
            {
                left = right;
                if(a)
                {

                }
            }
        }
    }
}