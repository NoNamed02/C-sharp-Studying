using System;

namespace A045
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원하는 구구단 : ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{value} * {i} = {value*i}");
            }
        }
    }
}
