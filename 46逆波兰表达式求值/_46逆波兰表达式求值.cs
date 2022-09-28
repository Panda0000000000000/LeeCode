using System.Runtime;

namespace _46逆波兰表达式求值
{
    internal class _46逆波兰表达式求值
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        //逆波兰表达式
        public int EvalRPN(string[] tokens)
        {
            Stack<int> resault = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                string str = tokens[i];
                int number;
                if (int.TryParse(str, out number))
                {
                    resault.Push(number);
                }
                else {
                    int b = resault.Pop();
                    int a = resault.Pop();
                    switch (str)
                    {
                        case "+":
                            resault.Push(a+b);
                            break;
                        case "-":
                            resault.Push(a - b);
                            break;
                        case "*":
                            resault.Push(a * b);
                            break;
                        case "/":
                            resault.Push(a / b);
                            break;
                    }
                }
            }

            return resault.Pop();
        }
    }
}