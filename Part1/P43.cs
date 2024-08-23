using System;

namespace A043
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1부터 100까지 합
            int sum = 0;
            for(int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine(sum);

            // 1부터 100까지 홀수 합
            sum = 0;
            for (int i = 1;i <= 100; i++)
                if((i % 2 ) == 1) sum += i;
            Console.WriteLine(sum);

            // 1+1/ 2+1/ 3+ 2+ 1/ .....
            double sub = 0.0;
            for (int i = 1; i <= 100; i++)
                sub += 1.0 / i;
            Console.WriteLine(sub);
        }
    }
}
