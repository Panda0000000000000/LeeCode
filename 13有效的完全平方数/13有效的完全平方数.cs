using System;

namespace _13有效的完全平方数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IsPerfectSquare_1(14);
        }

        //1.二分查找 但是超出了时间限制
        public static bool IsPerfectSquare_1(int num)
        {
            long l = 0, r = num;
            while(l <= r)
            {
                long mid = ((r - l) /2) + l;
                long sqr = mid * mid;
                if (sqr> num)
                {
                    r = mid - 1;
                }
                else if (sqr< num)
                {
                    l = mid + 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        //2.根据数学的规律写
        public static bool IsPerfectSquare_2(int num)
        {
            int judge = num;
            int start = 1;
            while (judge>0)
            {
                judge -= start;
                start += 2;
            }

            return judge == 0;
        }
    }
}