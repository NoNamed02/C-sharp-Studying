using System;

namespace P62
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[20];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = r.Next(100);
            }
            PrintArray(v);

            int max = v[0];
            for (int i = 0; v.Length > i; i++) if (v[i] > max) max = v[i];
            Console.WriteLine("최대값 : " + max);

            int min  = v[0];
            for (int i = 0; v.Length > i; i++) if (v[i] < min) min = v[i];
            Console.WriteLine("최소값 : " +  min);

            int sum = 0;
            for (int i =0; v.Length > i;i++) sum += v[i];
            Console.WriteLine($"합계 {sum}, 평균 {sum / v.Length}");
        }
        private static void PrintArray<T>(T[] value)
        {
            for (int i = 0; value.Length > i; i++)
            {
                Console.Write($"{value[i],5} ");
            }
            Console.WriteLine();
        }
    }
}
