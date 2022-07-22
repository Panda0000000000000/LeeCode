using System;

namespace _10猜数字大小
{
    class _10猜数字大小
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1/2);

            Console.ReadKey();
        }

        public int GuessNumber(int n)
        {
            int left = 1, right = n;

            while (left < right)
            {
                // int middle = (left+right)/2;
                int middle = ((right - left) / 2) + left;
                int resault = guess(middle);
                if (resault == 0)
                {
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
    }
}
