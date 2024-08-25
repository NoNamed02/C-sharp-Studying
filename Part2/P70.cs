using System;

namespace P70
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            Program x = new Program();
            Console.WriteLine($"가장 큰 수는 {x.Larger(x.Larger(a, b), c)}");
        }
        private int Larger(int a, int b)
        {
            return (a >  b) ? a : b;
        }
        */
        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            Console.WriteLine($"가장 큰 수는 {Larger(Larger(a, b), c)}");
        }
        private static int Larger(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
