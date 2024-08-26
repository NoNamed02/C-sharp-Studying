using System;

namespace P79 // 제귀함수
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("power x, y");
            Console.Write("x 입력 : ");
            string input = Console.ReadLine();
            Console.Write("y 입력 : ");
            string input2 = Console.ReadLine();
            Console.WriteLine($"{Power(Convert.ToDouble(input) , Convert.ToDouble(input2)) }");
        }
        private static double Power(double x, double y)
        {
            if (y == 0) return 1;
            else return x * Power(x, y-1);
        }
    }
}
