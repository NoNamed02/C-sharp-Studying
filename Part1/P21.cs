using System;

namespace A021
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second) || (first > 5);
            Console.WriteLine(result);


            result = (first == second) && (first > 5);
            Console.WriteLine(result);

            result = (first == second) ^ (first > 5);
            Console.WriteLine(result);

            result = !(first > 5);
            Console.WriteLine(result);
        }
    }
}
