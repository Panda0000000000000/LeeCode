/***************************************************
	日期：2022/09/05  14:38
	作者：夏
	描述：考点是二分查找法
****************************************************/



using System;

namespace _08搜索插入位置
{
    class 搜索插入位置
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        //这个还不行  这个的时间复杂度是O（n）  不是O（log n）  得用真正的二分查找法
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length < 2)
            {
                return 0;
            }

            int index = nums.Length / 2;
            int index_Start = 0;

            int int_Resault = 0;

            if (target > nums[index])
            {
                index_Start = index;
            }

            for (int i = index_Start; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    int_Resault = i;
                    break;
                }
            }

            return int_Resault;
        }
    }
}