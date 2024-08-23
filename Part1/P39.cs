using System;

namespace A039
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = i + 10;
            int j = (int)o;
            Console.WriteLine($"V type i = {i}");
            Console.WriteLine($"O type o = {o}");
            Console.WriteLine($"V type j = {j}");

            object p = o;
            o = 100;

            Console.WriteLine($"O type o = {o}");
            Console.WriteLine($"O type p = {p}");
        }
    }
}
