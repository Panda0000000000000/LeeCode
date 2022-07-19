using System;

namespace 寻找两个有序数组的中位数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double rsault=   FindMedianSortedArrays_1_S(new int[] {1,2 }, new int[] { 3,4});
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

        //暴力求解
        public static double FindMedianSortedArrays_1_S(int[] nums1, int[] nums2)
        {
            int a = nums1.Length, b = nums2.Length;
            int len = a + b;
            int[] numsResault = new int[len];
            int resault = 0;
            int a_Start = 0, b_Start = 0;

            for (int i = 0; i < len; i++)
            {
                if (a==0)
                {
                    numsResault[resault++] = nums2[a_Start++];
                    continue;
                }

                if (b==0)
                {
                    numsResault[resault++] = nums1[b_Start++];
                    continue;
                }

                if (a_Start>=a)
                {
                    numsResault[resault++] = nums2[b_Start++];
                    continue;
                }

                if (b_Start>=b)
                {
                    numsResault[resault++] = nums1[a_Start++];
                    continue;
                }   

                if (nums1[a_Start] <= nums2[b_Start])
                {
                    numsResault[resault++] = nums1[a_Start++];
                }
                else
                {
                    numsResault[resault++] = nums2[b_Start++];
                }
            }

            if ((len & 1) == 0)
            {
                return (numsResault[len / 2-1] + numsResault[len / 2]) / 2.0;
            }
            else
            {
                return numsResault[len / 2];
            }
        }

        //循环遍历查找法  第K小的数
        public static double FindMedianSortedArrays_2(int[] nums1, int[] nums2)
        {
            int a = nums1.Length, b = nums2.Length;
            int aStart = 0, bStart = 0;

            int left = -1, right = -1;
            int len = a + b;
            for (int i = 0; i < (len / 2)+1; i++)
            {
                left = right;
                if (aStart < a && (bStart >= b || nums1[aStart] < nums2[bStart]))
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

        //二分查找法
        public static double FindMedianSortedArrays_3(int[] nums1, int[] nums2)
        {
            int n = nums1.Length, m = nums2.Length;
            int left = (n + m + 1) / 2;
            int right = (n + m + 2) / 2;

            return (getKth(nums1, 0, n - 1, nums2, 0, m - 1, left) + getKth(nums1, 0, n - 1, nums2, 0, m - 1, right));

            int getKth(int[] nums1,int start1,int end1,int[] nums2,int start2,int end2,int k){
                int len1 = end1 - start1 + 1;
                int len2 = end2 - start2 + 1;

                if(len1>len2)
                {
                    return getKth(nums2, start2, end2, nums1, start1, end1, k);
                }
                if (len1==0) 
                {
                    return nums2[start2 + k - 1];
                }

                if (k==1)
                {
                    return Math.Min(nums1[start1], nums2[start2]);
                }

                int i = start1 + Math.Min(len1, k / 2) - 1;
                int j = start2 + Math.Min(len2, k / 2) - 1;

                if (nums1[i] > nums2[j])
                {
                    return getKth(nums1, start1, end1, nums2, j + 1, end2, k - (j - start2 + 1));
                }
                else
                {
                    return getKth(nums1, i + 1, end1, nums2, start2, end2, k - (i - start1 + 1));
                }
            }
        }
    }
}