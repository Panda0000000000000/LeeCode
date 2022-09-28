/***************************************************
	日期：2022/09/06  22:18
	作者：夏
	描述：考点就是动态规划
****************************************************/

using System;
using System.Collections.Generic;

namespace _17鸡蛋掉落
{
    class _17鸡蛋掉落
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //动态规划
        public int SuperEggDrop_1(int k, int n,string a)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

        }

        //数学法  Error
        public int SuperEggDrop_2(int k, int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int[,] f = new int[n, k];
            for (int i = 0; i < k; i++)
            {
                f[1, i] = 1;
            }
            int ans = -1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    f[i, j] = 1 + f[i - 1, j - 1] + f[i - 1, j];
                }
                if (f[i, k] >= n)
                {
                    ans = i;
                    break;
                }
            }

            return ans;
        }
    }
}