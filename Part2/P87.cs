using System;

namespace P87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("생애 계산기");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime dateN = DateTime.Now;

            TimeSpan span = dateN - date;
            Console.WriteLine($"생존 시간 {span.ToString()}");
            Console.WriteLine($"{span.Days} {span.Hours} {span.Minutes}");
        }
    }
}
