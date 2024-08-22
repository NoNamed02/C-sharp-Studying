using System;

namespace A029
{
    class Program
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s = String.Format($"현재 원달러 환율은 {exchangeRate}입니다.");
            Console.WriteLine(s);

            s = String.Format($"현재 원달러 환율은 {exchangeRate:C2}입니다.");
            Console.WriteLine(s);

            s = String.Format($"오늘 날짜는 {DateTime.Now:d}, 시간은 {DateTime.Now:t} 입니다.");
            Console.WriteLine(s);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = $"소요시간: {duration:c}";
            Console.WriteLine(output);
        }
    }
}
