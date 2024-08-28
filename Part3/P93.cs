using System;

namespace P93
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "AB", "BC", "CD" };

            Print<int>(a);
            Print<double>(d);
            Print<string>(s);
        }
        private static void Print<T>(T[] values)
        {
            foreach (var v in values)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
    }
}
