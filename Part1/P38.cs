using System;

namespace A038
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine(i.GetValueOrDefault());

            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("null");

            int? x = null;
            int j = x ?? 0;
            Console.WriteLine($"x = {x}, j = {j}");

            Console.WriteLine($"x >= 10 ? {x >= 10}");
            Console.WriteLine($"x < 10 ? {x < 10}");

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else
                Console.WriteLine("i = j");
        }
    }
}
