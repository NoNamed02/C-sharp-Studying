using System;
// string 정렬
namespace P60
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "B", "A", "D", "C" };
            PrintArray(name);

            Array.Reverse(name);
            PrintArray(name);

            Array.Sort(name);
            PrintArray(name);

            Array.Reverse(name);
            PrintArray(name);
        }

        private static void PrintArray(string[] str)
        {
            foreach (var value in str)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
