﻿using System;

namespace _08搜索插入位置
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
