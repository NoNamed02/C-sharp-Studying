using System;
using System.Collections.Generic;

namespace P103
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random r = new Random();

            Print(a);

            for (int i = 0; i< 10; i++)
            {
                a.Add(r.Next(100));
            }
            Print(a);
            a.Sort();
            Print(a);

            a.RemoveAt(3);
            Print(a);
        }
        private static void Print(List<int> a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
