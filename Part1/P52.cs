using System;

namespace P52
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; ; i++)
            {
                sum += i;
                if(sum >= 10000)
                {
                    Console.WriteLine($"1~{i}의 합 {sum}");
                    break;
                }
            }

            sum = 0;
            int index = 1;
            for(; sum < 10000; index++)
            {
                sum += index;
            }
            Console.WriteLine($"1~{index-1}의 합 {sum}");
        }
    }
}
