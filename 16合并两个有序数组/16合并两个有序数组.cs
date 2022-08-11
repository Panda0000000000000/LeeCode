using System;

namespace _16合并两个有序数组
{
    class _16合并两个有序数组
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }

        //归并排序
        public static void Merge_1(int[] nums1, int m, int[] nums2, int n)
        {
            int a = 0, b = 0;
            int[] resault=new int[m+n];
            int resault_Pos=0;

            int a_Length = nums1.Length;
            int b_Length = nums2.Length;

            while (a<m||b<n)
            {
                if (a>= m)
                {
                    resault[resault_Pos++] = nums2[b++];
                    continue;
                }
                if (b>= n)
                {
                    resault[resault_Pos++] = nums1[a++];
                    continue;
                }
                if (nums1[a] <= nums2[b])
                {
                    resault[resault_Pos++] = nums1[a++];
                }
                else
                {
                    resault[resault_Pos++] = nums2[b++];
                }
            }

            for (int i = 0; i < resault.Length; i++)
            {
                nums1[i] = resault[i];
            }
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

        }
    }
}