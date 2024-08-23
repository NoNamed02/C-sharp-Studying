using System;

namespace A047
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x의 y승 계산");
            Console.Write("x 입력 : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y 입력 : ");
            int y = int.Parse(Console.ReadLine());

            int sum = 1;
            for (int i = 0; i < y; i++)
            {
                sum *= x;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
