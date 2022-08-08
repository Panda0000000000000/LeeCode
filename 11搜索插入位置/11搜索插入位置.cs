using System;

namespace _11搜索插入位置
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int resault = SearchInsert(new int[]{ 1, 3, 5, 6 }, 2);
        }

        //二分法的这个写法还是不太懂，但是不在这里浪费时间了
        public static int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length-1;
            while (l<=r)
            {
                int m = (r - l) / 2 + l;
                if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            return l;
        }
    }
}