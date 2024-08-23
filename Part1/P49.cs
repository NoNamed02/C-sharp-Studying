using System;

namespace A049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("소수 판별 하고싶은 숫자 : ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n}은 소수가 아님"); break;
                }
            }
            if (n ==i) Console.WriteLine($"{n}은 소수");
        }
    }
}
