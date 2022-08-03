using System;

namespace _11搜索插入位置
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int resault = SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length-1;
            while (l<r)
            {
                int m = (r - l) / 2 + l;
                if (nums[l] > target)
                {
                    r = m - 1;
                }
                if (nums[l] < target)
                {
                    l = m + 1;
                }
                if (nums[l] == target)
                {
                    return l;
                }
            }

            return l;
        }
    }
}