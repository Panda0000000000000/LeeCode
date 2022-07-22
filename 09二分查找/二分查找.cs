using System;

namespace _09二分查找
{
    class 二分查找
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a=  Search(new int[]{-1,0,3,5,9,12}, 13);
            Console.ReadKey();
        }

        public static int Search(int[] nums, int target)
        {
            if (nums.Length<2)
            {
                if (nums[0]==target)
                {
                    return 0;
                }

                return -1;
            }

            int int_Resault = -1;
            int int_Index = nums.Length / 2;

            int left = 1, right = nums.Length;

            void find(int[] nums,int target,int left,int right, ref int resault)
            {
                int middle = (right - left) / 2 + left;

                if (right-left<2)
                {
                    if (nums[left-1] == target)
                    {
                        resault = left-1;
                        return;
                    }

                    if (nums[right-1]==target)
                    {
                        resault = right-1;
                        return;
                    }
                    return;
                }

                if (nums[middle-1]==target)
                {
                    resault = middle-1;
                    return;
                }
                if (nums[middle-1] < target)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }

                find(nums, target, left, right, ref resault);
            }

            find(nums, target, left,right,ref int_Resault);

            return int_Resault;
        }
    }
}