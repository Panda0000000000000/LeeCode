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
            int n = arr.Length;
            int l = 1, r = n - 2, ans = 0;
            while (l<=r)
            {
                int mid = (r - l) >> 1 + l;
                if (arr[mid] > arr[mid + 1])
                {
                    ans = mid;
                    r= mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return ans;
        }
    }
}