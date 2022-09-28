/***************************************************
	日期：2022/08/28  16:44
	作者：夏
	描述：设计一个支持 push ，pop ，top 操作，并能在常数时间内检索到最小元素的栈。
            //维护两个栈确实可以实现，但显然太简单得东西不是我们的风格
        //用最小值来维护 ，存储最小值，然后在栈里面存储和该最小值的差值，
****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;

namespace _36最小栈
{
    class _36最小栈
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestStack();
        }

        static void TestStack()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-3);
            minStack.Push(0);
            minStack.Push(-2);
            minStack.Pop();
            long a = minStack.Top();
            long b = minStack.GetMin();

        }

        public class MinStack
        {
            Stack<long> stack_Nomal;
            long min = long.MinValue;
            public MinStack()
            {
                stack_Nomal = new Stack<long>();
            }

            public void Push(int val)
            {
                if (stack_Nomal.Count == 0)
                {
                    min = val;
                    stack_Nomal.Push(0);
                }
                else
                {
                    long difference = val - min;
                    if (difference<0)
                    {
                        min = val;
                    }
                    stack_Nomal.Push(difference);
                }
            }

            public void Pop()
            {
                if (stack_Nomal.Count == 0)
                {
                    return;
                }

                long val =  stack_Nomal.Pop();
                if (val<0)
                {
                    min -= val;
                }
            }

            public int Top()
            {
                if (stack_Nomal.Count == 0)
                {
                    return 0;
                }

                long val = stack_Nomal.Peek();
                if (val > 0)
                {
                    return (int)(val + min);
                } else
                {
                    return (int)min;
                }
            }

            public int GetMin()
            {
                return (int)min;
            }
        }
    }
}
