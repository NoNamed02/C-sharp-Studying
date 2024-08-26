using System;

namespace P81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - 10 역수 합 = {0}", Sum(10));
        }
        private static double Sum(int n)
        {
            if (n == 1) return 1;
            else return 1.0 / n + Sum(n - 1);
        }
    }
}
