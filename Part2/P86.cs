using System;

namespace P86
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Today.AddDays(1);

            TimeSpan span = d2 - d1;
            Console.WriteLine($"{span, 12}");
            Console.WriteLine($"{span.Days,12}");
            Console.WriteLine($"{span.Hours,12}");
            Console.WriteLine($"{span.Minutes,12}");
            Console.WriteLine($"{span.Seconds,12}");
            Console.WriteLine($"{span.Milliseconds,12}");

            Console.WriteLine();

            Console.WriteLine($"{span,12}");
            Console.WriteLine($"{span.TotalDays,12}");
            Console.WriteLine($"{span.TotalHours,12}");
            Console.WriteLine($"{span.TotalMinutes,12}");
            Console.WriteLine($"{span.TotalSeconds,12}");
            Console.WriteLine($"{span.TotalMilliseconds,12}");
        }
    }
}
