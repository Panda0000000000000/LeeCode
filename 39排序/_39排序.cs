using System;

namespace _39排序
{
    class _39排序
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[] { 9, 10, 7, 6, 8, 5, 19 };
            sort(a,0,6);
            Console.WriteLine("Hello World!");
        }

        //快速排序
        public static void sort(int[] array,int l_,int r_)
        {
            if (l_>=r_)
            {
                return;
            }

            int l = l_, r = r_;
            int p = l;
            int pValue = array[p];
            while (l < r)
            {
                //先找到右边可以替换的数
                while (r > l && array[r] > pValue)
                {
                    r--;
                }

                if (r > l && array[r] < pValue)
                {
                    array[l] = array[r];
                    l++;
                }

                while (l < r && array[l] < pValue)
                {
                    l++;
                }

                if (l < r && array[l] > pValue)
                {
                    array[r] = array[l];
                    r--;
                }
                if (l == r)
                {
                    array[l] = pValue;
                }
            }

            sort(array, l_, r - 1);
            sort(array, r+1,r_);
        }
    }
}