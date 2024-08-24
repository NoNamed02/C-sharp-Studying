using System;

namespace P53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for(int j = 2; j <= i; j++)
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine($"{i}! = {fact}");
            }
            Console.WriteLine($"총합 {sum}");
        }   
    }
}
