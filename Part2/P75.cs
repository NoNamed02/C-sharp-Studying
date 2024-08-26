using System;

namespace P75
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += Factorial(i);
                Console.WriteLine($"{i,2}! : {Factorial(i), 10:N0}");
            }
            Console.WriteLine($"{sum:N0}");
        }
        private static int Factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
