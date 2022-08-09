using System;

namespace _12山脉数组的峰顶索引
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //1.暴力解法  太简单，写出来也是侮辱智商  就不写具体代码了

        //2.二分解法
        public int PeakIndexInMountainArray(int[] arr)
        {
            int l = 0, r = arr.Length - 1;
            while(l<r)
            {
                int mid = ((r - l) >> 1) +l;
                if (arr[mid] > arr[mid+1])
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return l;
        }
    }
}