using System;

namespace P84
{
    class Program
    {
        static int[] f = new int[50];
        static void Main(string[] args)
        {
            Console.Write("값 입력 : ");
            int n = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();

            f[1] = f[2] = 1;
            for(int i = 3; i <=n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{f[i]} ");
            }
            Console.WriteLine();
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"실행시간 {elapsedMs}ms\n");

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 1; i <= n; i++)
                Console.Write($"{Fibo(i)} ");
            Console.WriteLine();

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"실행시간 {elapsedMs}ms\n");
        }
        private static int Fibo(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
