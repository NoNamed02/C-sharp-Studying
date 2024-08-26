using System;
namespace P80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5! = {Fact(5)}");
        }
        private static double Fact(double n)
        {
            if (n == 0) return 1;
            else return n * Fact(n - 1);
        }
    }
}
