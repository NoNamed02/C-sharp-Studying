using System;
using System.Collections;

namespace P102
{
    class Program
    {
        static void Main(string[] args)
        { 
            ArrayList a = new ArrayList();
            Random r = new Random();

            Print(a);

            for (int i = 0; i < 10; i++)
            {
                a.Add(r.Next(100));
            }
            Print(a);
            a.Sort();
            Print(a);

            a.RemoveAt(3);
            Print(a);
        }
        private static void Print(ArrayList a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
