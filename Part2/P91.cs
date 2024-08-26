using System;

namespace P91
{
    class Program
    {
        static int Power(int x, int y = 2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        static int Area(int h, int w)
        {
            return h * w;
        }

        static void Print(int a, int b)
        {
            Console.WriteLine($"{a}, {b}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Power(1, 2));
            Console.WriteLine(Power(2));

            Console.WriteLine(Area(2, 3));
            Console.WriteLine(Area(w:5, h:3));

            Print(b: 3, a: 6);
        }
    }
}
