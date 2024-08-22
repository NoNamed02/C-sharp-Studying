using System;

namespace A022
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 11, result;

            result = x | y;
            Console.WriteLine(result);

            result = x & y;
            Console.WriteLine(result);

            result = x ^ y;
            Console.WriteLine(result);

            result = ~x;
            Console.WriteLine(result);

            result = x << 2;
            Console.WriteLine(result);

            result = x >> 1;
            Console.WriteLine(result);
        }
    }
}
