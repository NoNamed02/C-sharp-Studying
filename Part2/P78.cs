using System;
namespace P78
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double r = 1; r <= 10; r++)
            {
                Console.WriteLine($"Area of circle wity radius {r,2} = {Circle(r)}");
            }
        }
        private static double Circle(double r)
        {
            return Math.PI * r * r;
        }
    }
}
