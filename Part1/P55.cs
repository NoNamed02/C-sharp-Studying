using System;

namespace P55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int index;
            for (int i = 2; i <= 1000; i++)
            {
                for (index = 2; index < i; index++)
                {
                    if (i % index == 0)
                        break;
                }
                if (i == index)
                {
                    n++;
                    Console.Write($"{index,5}");
                }
            }
            Console.WriteLine($"소수는 {n}개");
        }
    }
}
