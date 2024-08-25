using System;
namespace P57
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Console.Write("a[]: ");
            foreach(var value in a) Console.Write($"{value} ");

            int[] b = { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for(int i = 0; i < 3; i++) Console.Write($"{b[i]} ");

            int[] c = { 1, 2, 3 };
            Console.Write("\nc[]: ");
            for(int i = 0; i < c.Length;  i++) Console.Write($"{c[i]} ");
        }
    }
}
