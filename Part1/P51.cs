using System;
namespace A051
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)
            {
                sum += money;
                Console.WriteLine($"{days}일차 : {money,8:C} sum = {sum, 11 :C}");
                if (sum >= 1000000) break;
                days++;
                money *= 2;
            }
            Console.WriteLine($"{days}일차에 {sum:###,###}원이 됨");

            for (sum = 0, days = 1, money = 1000; ; days++, money*=2)
            {
                sum += money;
                Console.WriteLine($"{days}일차 : {money,8:C} sum = {sum,11:C}");
                if (sum >= 1000000) break;
            }
            Console.WriteLine($"{days}일차에 {sum:###,###}원이 됨");
        }
    }
}
