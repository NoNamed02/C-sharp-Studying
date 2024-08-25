using System;

namespace P58
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            PrintArray(a);

            int[] b = (int[])a.Clone();
            PrintArray(b);

            int[] c = new int[20];
            Array.Copy(a, 0, c, 1, 3);
            PrintArray(c);

            a.CopyTo(c, 3);
            PrintArray(c);

            Array.Sort(a);
            PrintArray(a);

            Array.Reverse(a);
            PrintArray(a);

            Array.Clear(a, 0, a.Length);
            PrintArray(a);
        }
        private static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
