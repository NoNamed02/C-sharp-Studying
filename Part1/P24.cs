using System;

namespace A024
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 2);
            Console.WriteLine(x--);
            Console.WriteLine(--x);
        }
    }
}
