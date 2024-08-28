using System;

namespace P95
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 45, 32, 47, 85, 46, 85, 46, 93, 47, 50, 71 };
            float[] b = { 1.2f, 5.3f, 7.8f, 6.1f, 3.4f, 8.8f };

            Calc<int>(a);
            Calc<float>(b);
            Print<int>(a);
            Print<float>(b);
        }

        private static void Calc<T>(T[] values) where T : struct
        { 
            T sum = default(T);
            T avg = default(T);
            T max = default(T);

            foreach (dynamic item in values)
            {
                if (max < item) max = item;
                sum += item;
            }
            avg = (dynamic)sum / values.Length;
            Console.WriteLine($"{sum,5}, {avg,5}, {max,5}");
        }

        private static void Print<T>(T[] values) where T : struct
        {
            foreach (var item in values) Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
