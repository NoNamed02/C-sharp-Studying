using System;

namespace A04_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"10진수" : 5} {"2진수" : 8} {"8진수" : 3} {"16진수" : 4}");

            for (int i = 1; i <= 128; i++)
            {
                Console.WriteLine($"{i , 7} {Convert.ToString(i, 2).PadLeft(8,'0') : 10} {Convert.ToString(i, 8) : 5} {Convert.ToString(i, 16) : 16}");
            }
        }
    }
}
