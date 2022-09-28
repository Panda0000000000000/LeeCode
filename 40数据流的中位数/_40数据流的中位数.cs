/***************************************************
	日期：2022/08/31  12:05
	作者：夏
	描述：需要用到.Net6.0的框架，先不弄  这里是维护两个堆来实现的  现在搞来了6.0的框架了
    
            //理解不了这里的代码
****************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _40数据流的中位数
{
    class _40数据流的中位数
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class MedianFinder
        {
            PriorityQueue<int, int> queMin;
            PriorityQueue<int, int> queMax;
            public MedianFinder()
            {
                queMin=new PriorityQueue<int, int>();
                queMax=new PriorityQueue<int, int>();
            }

            public void AddNum(int num)
            {
                if(queMin.Count == 0 || num <queMin.Peek())
                {
                    queMin.Enqueue(num, -num);
                    if (queMax.Count+1<queMin.Count)
                    {
                        int val = queMin.Dequeue();
                        queMax.Enqueue(val,val);
                    }
                }
            }

            public double FindMedian()
            {

            }
        }
    }
}