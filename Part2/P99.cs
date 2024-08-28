using System;

namespace P99
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Random r = new Random();

            for (int i = 0; i< 10; i++)
            {
                int val = r.Next(100);
                stack.Push(val);
                Console.Write(val + " push ");
            }
            Console.WriteLine();

            for (int i = 0; i< 10;i++)
            {
                Console.Write("pop() = " + stack.Pop() + ", "); ;
            }
        }
    }
}
