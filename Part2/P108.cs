using System;
using System.Collections;
using System.Collections.Generic;

namespace P108
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("T");
            que.Enqueue("L");
            que.Enqueue("Z");
            que.Enqueue("C");

            Print(que);

            Console.WriteLine($"dequeue : {que.Dequeue()}");

            Queue<string> que2 = new Queue<string>(que.ToArray());
            Print(que2);

            string[] arr = new string[que.Count];
            que.CopyTo(arr, 0);
            Queue<string> que3 = new Queue<string>(arr);
            Print(que3);
        }

        private static void Print<T>(Queue<T> queue)
        {
            foreach (var value in queue)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
