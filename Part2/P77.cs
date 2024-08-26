using System;

namespace P77
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"2 ^ {i} = {Power(2, i)}");
            }
        }
        private static int Power(int a, int b)
        {
            int p = 1;
            for (int i = 1; i <= b; i++)
            {
                p *= a;
            }
            return p;
        }
    }
}
