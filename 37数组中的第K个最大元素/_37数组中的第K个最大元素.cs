
using System;
using System.ComponentModel;

namespace _37数组中的第K个最大元素
{
    class _37数组中的第K个最大元素
    {
        static void Main(string[] args)        {
            Console.WriteLine("Hello World!");
            HeapSort(new int[] { 3, 2, 1, 5, 6, 4 },2);
        }

        //用现成的排序写
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);

            int len = nums.Length;
            return nums[len-k];
        }

        //堆排序
        static int HeapSort(int[] nums,int k)
        {
            if (nums == null || nums.Length == 0) return -1;

            BuildHeap(nums);

            int len = nums.Length - 1;

            for (int i = nums.Length-1; i >nums.Length-1- k ; i--)
            {
                Swap(nums, 0, i);
                Heapify(nums, 0, len--);
            }

            return nums[nums.Length - k];

            void BuildHeap(int[] nums)
            {
                int start = nums.Length / 2 - 1;
                for (int i = start; i >= 0; i--)
                {
                    Heapify(nums, i, nums.Length);
                }
            }

            static void Heapify(int[] nums,int i,int len)
            {
                int left = i * 2 + 1;
                int right = i * 2 + 2;
                int index = i;
                if (left < len && nums[left] > nums[index])
                {
                    index = left;   
                }
                if (right < len && nums[right] > nums[index])
                {
                    index = right;
                }

                if (index!=i)
                {
                    Swap(nums, index, i);
                    Heapify(nums, index, len);
                }
            }

            static void Swap(int[] nums, int i, int j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }

    }
}