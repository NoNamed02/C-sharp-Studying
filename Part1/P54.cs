using System;

namespace P54
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 10; i++)
            {
                for (int j = 1 ; j < 10; j++)
                {
                    Console.Write($"{i} X {j} = {i * j,3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
