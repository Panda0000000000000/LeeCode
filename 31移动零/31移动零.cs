/***************************************************
	日期：2022/08/28  12:38
	作者：夏
	描述：给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
    请注意 ，必须在不复制数组的情况下原地对数组进行操作。
        
        
****************************************************/

using System;

namespace _31移动零
{
    class _31移动零
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        //两次遍历
        // 通过一个指针，把所有非0的值全赋完，剩下的就全是0
        public void MoveZeroes_1(int[] nums)
        {
            if (nums==null)
            {
                return; 
            }
            int len = nums.Length;
            int j = 0;
            for(int i = 0; i < len; i++)
            {
                if (nums[i]!=0)
                {
                    nums[j++] = nums[i];
                }
            }

            for (int i = j; i < len; i++)
            {
                nums[i] = 0;
            }
        }

        //一次遍历
        public void MoveZeroes_2(int[] nums)
        {
            int len = nums.Length;
            int j = 0;

            for (int i = 0; i < len; i++)
            {
                if (nums[i]!=0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j++] = temp;
                }
            }
        }
    }
}
