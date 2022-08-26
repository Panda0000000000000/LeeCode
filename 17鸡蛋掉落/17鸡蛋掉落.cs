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

        //动态规划+二分查找
        public int SuperEggDrop_1(int k, int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            int dp(int k, int n)
            {
                if (!memo.ContainsKey(n * 100 + k))
                {
                    int ans; ;
                    if (n == 0)
                    {
                        ans = 0;
                    }
                    else if (k == 1)
                    {
                        ans = n;
                    }
                    else
                    {
                        int lo = 1, hi = n;
                        while (lo + 1 < hi)
                        {
                            int x = (lo + hi) / 2;
                            int t1 = dp(k - 1, x - 1);
                            int t2 = dp(k, n - x);
                            if (t1 < t2)
                            {
                                lo = x;
                            }
                            else if (t1 > t2)
                            {
                                hi = x;
                            }
                            else
                            {
                                lo = hi = x;
                            }
                            ans = 1 + Math.Min(Math.Max(dp(k - 1, lo - 1), dp(k, n - lo)), Math.Max(dp(k - 1, hi - 1), dp(k, n - hi)));
                        }
                    }
                }
            }
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