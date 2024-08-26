using System;

namespace P92
{
    class Program
    {
        static void Print(double n)
        {
            Console.WriteLine("double " + n);
        }
        static void Print(int n)
        {
            Console.WriteLine("int " + n);
        }
        static void Main(string[] args)
        {
            Print(2.0);
            Print(3);
        }
    }
}
