using System;
namespace A048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n!계산");
            Console.Write("n입력 : ");
            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            for(int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine("팩토리얼 값 {0}", sum);
        }
    }
}
