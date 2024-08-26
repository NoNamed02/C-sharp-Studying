using System;

namespace P82
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50 ; i++)
            {
                double m = Mersenne(i);
                Console.WriteLine($"메르센 수 {i} = {m:N} = {m / 3600 / 24:N} = {m / 3600 / 24 / 365:N}");
            }
            Console.WriteLine($"하노이 : 4, {'A'} - {'B'} - {'C'}");
            Hanoi(4, 'A', 'B', 'C');
        }
        private static double Mersenne(int n)
        {
            return Math.Pow(2, n) - 1;
        }

        private static void Hanoi(int n, char from, char to, char by)
        {
            if (n == 1) Console.WriteLine($"{from} -> {to}");
            else
            {
                Hanoi(n - 1, from, by, to);
                Console.WriteLine($"{from} -> {to}");
                Hanoi(n - 1, by, to, from);
            }
        }
    }
}
