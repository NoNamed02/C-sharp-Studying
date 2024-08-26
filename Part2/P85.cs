using System;

namespace P85
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(1992, 7, 4, 8, 43, 0);
            DateTime date2 = new DateTime(1990, 1, 27, 12, 6, 0);

            Console.WriteLine(date1);
            Console.WriteLine(date2);

            Console.WriteLine($"{date1.ToString("yyyy년 M월 d일")}과 {date2.ToString("yyyy년 M월 d일")}차이는 {date1.Subtract(date2).Days}입니다.");

            Console.WriteLine($"오늘 {DateTime.Today}");
            Console.WriteLine($"어제 {DateTime.Today.AddDays(-1)}");
            Console.WriteLine($"내일 {DateTime.Today.AddDays(1)}");

            DateTime d = DateTime.UtcNow;

            Console.WriteLine(d);
        }
    }
}
