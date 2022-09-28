using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace _44基本计算器II
{
    internal class _44基本计算器II
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calculate_1("42");
        }


        //两个栈
        //自己写的 最后的结果是错的 根本的原因在于 没控制好两个栈中数字计算的顺序
        public static int Calculate(string s)
        {
            s = s.Replace(" ", "");
            char[] chars = s.ToCharArray();
            Stack<int> numbers = new Stack<int>();
            Stack<char> symbles = new Stack<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (char.IsDigit(c))
                {
                    int num = 0;
                    num = num * 10 + c - '0';
                    while (i+1 < chars.Length&&char.IsDigit(chars[i+1]))
                    {
                        i++;
                        num = num * 10 + (chars[i] - '0');
                        if (i>=chars.Length)
                        {
                            break;
                        }
                    }
                    numbers.Push(num);
                }
                else if (c != ' ')
                {
                    symbles.Push(c);
                }
            }

            int first = numbers.Pop();
            while (symbles.Count >= 1)
            {
                int number = numbers.Pop();
                int symble = symbles.Pop();
                switch (symble)
                {
                    case '+':
                        numbers.Push(number + first);
                        break;
                    case '-':
                        numbers.Push(first-number);
                        break;
                    case '*':
                        numbers.Push(first * number);
                        break;
                    case '/':
                        numbers.Push(number/first);
                        break;
                }
                first = numbers.Pop();
            }
            return first;

        }

        //官方给的代码  一个栈
        public static int Calculate_1(string s)
        {
            Stack<int> stack = new Stack<int>();
            char[] chars = s.ToCharArray();
            char preSign = '+';
            int num = 0;
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                char a = chars[i];
                if (char.IsDigit(a))
                {
                    num = (num * 10) + (a - '0');
                }
                if (!char.IsDigit(a)&&a!=' '||i==n-1)
                {
                    switch (preSign)
                    {
                        case '+':
                            stack.Push(num);
                            break;
                        case '-':
                            stack.Push(-num);
                            break;
                        case '*':
                            stack.Push(stack.Pop()* num);
                            break;
                        case '/':
                            stack.Push(stack.Pop() / num);
                            break;
                        default:
                            break;
                    }
                    num = 0;
                    preSign = a;
                }
            }

            int ans = 0;
            while (stack.Count>0)
            {
                ans += stack.Pop();
            }

            return ans;
        }
    }
}