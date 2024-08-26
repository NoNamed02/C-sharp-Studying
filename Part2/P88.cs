using System;
using System.Globalization;

namespace P88
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("yyyy MM dd");
            Console.WriteLine("MMMM dd, yyyy ddd",
                CultureInfo.CreateSpecificCulture("en-US"));

            Console.WriteLine("d : " + today.ToString("d"));
            Console.WriteLine("D : " + string.Format($"{today:D}"));
            Console.WriteLine("t : " + string.Format($"{today:t}"));
            Console.WriteLine("T : " + string.Format($"{today:T}"));
            Console.WriteLine("g : " + string.Format($"{today:g}"));
            Console.WriteLine("G : " + string.Format($"{today:G}"));
            Console.WriteLine("f : " + string.Format($"{today:f}"));
            Console.WriteLine("F : " + string.Format($"{today:F}"));
            Console.WriteLine("s : " + string.Format($"{today:s}"));
            Console.WriteLine("o : " + string.Format($"{today:o}"));
            Console.WriteLine("r : " + string.Format($"{today:r}"));
            Console.WriteLine("u : " + string.Format($"{today:u}"));


        }
    }
}
