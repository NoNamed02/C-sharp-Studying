using System;
namespace P76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 ~ 100 합 {Sum(0,100)}");
            Console.WriteLine($"101 ~ 200 합 {Sum(101, 200)}");
        }
        private static int Sum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
