using System;

namespace P71
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }

        private static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
