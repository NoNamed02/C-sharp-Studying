using System;

namespace P98
{
    class Stack<T>(T data)
    {
        const int max = 10;
        private T[] arr = new T[max];
        private int top;
        public Stack()
        {
            top = 0;
        }

        public void Push(T item)
        {
            if (top < max) {
                arr[top] = item;
                top++;
            }
            else
            {
                Console.WriteLine("stack full");
                return;
            }
        }

        public T Pop()
        {
            if(top > 0)
            {
                --top;
                return arr[top];
            }
            else
                return default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
