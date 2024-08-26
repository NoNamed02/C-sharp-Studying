using System;

namespace P74
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(5);
            Draw(3);
        }

        private static void Draw(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
