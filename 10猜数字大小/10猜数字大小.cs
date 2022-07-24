using System;

namespace _10猜数字大小
{
    class _10猜数字大小
    {

        static int _Resault = 1702766719;

        static void Main(string[] args)
        {
            Console.WriteLine(1/2);

            double n = 2126753390;
            double resault =  GuessNumber(2126753390);

            Console.ReadKey();
        }

        public static double GuessNumber(double n)
        {
            double left = 2, right = n;

            double int_LoopCount = 0;

            while (left < right)
            {
                //int middle = (left + right) / 2;
                double middle = ((right - left) / 2.0) + left;
                double resault = guess(middle);

                int_LoopCount++;

                Console.WriteLine("执行的步骤 "+int_LoopCount+ " Left值：" + left+"  Right值："+right+" middle值："+middle);

                if (resault == 0)
                {
                    Console.WriteLine("执行的总次数为：" + int_LoopCount);
                    left = middle;
                    return left;
                }
                if (resault == -1)
                {
                    right = middle;
                }
                if (resault == 1)
                {
                    left = middle + 1;
                }
            }
            return left;
        }

        static double guess(double n)
        {
            if (n== _Resault)
            {
                return 0;
            }
            if (n< _Resault)
            {
                return 1;
            }

            return -1;
        }
    }
}
